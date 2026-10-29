using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.IO;


namespace DiscMerge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private List<MusicFile>[] mfLists = new List<MusicFile>[] { new List<MusicFile>(), new List<MusicFile>() };


        private void BrowseLoad(System.Windows.Forms.TextBox textBox)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                textBox.Text = fbd.SelectedPath;
            }
        }

        private void dirBrowseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = null;

            switch (((Button)sender).Name)
            {
                case "dir1BrowseButton":
                    tb = dir1TextBox;
                    break;
                case "dir2BrowseButton":
                    tb = dir2TextBox;
                    break;
                case "dirOutBrowseButton":
                    tb = dirOutTextBox;
                    break;
            }

            if (tb != null)
            {
                BrowseLoad(tb);
            }
        }

        private void analyseButton_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                dir1GridView.DataSource = dir2GridView.DataSource = null;

                mfLists[0].Clear();
                mfLists[1].Clear();
                

                string dir1 = dir1TextBox.Text.Trim();
                string dir2 = dir2TextBox.Text.Trim();

                if (dir1 == string.Empty || dir2 == string.Empty)
                {
                    throw (new Exception("Both directories must be specified"));
                }

                if (dir1.Equals(dir2, StringComparison.CurrentCultureIgnoreCase))
                {
                    throw (new Exception("Directories cannot be the same"));
                }

                LoadMFList(mfLists[0], dir1);
                LoadMFList(mfLists[1], dir2);

                dir1GridView.DataSource = mfLists[0]; dir2GridView.DataSource = mfLists[1];

                int count1 = mfLists[0].Count;
                int count2 = mfLists[1].Count;
                int totalCount = count1 + count2;

                int total = mfLists[0].Count + mfLists[1].Count;

                for (int i = 0; i < count1; i++)
                {
                    mfLists[0][i].NewTrackNumber = (uint)i + 1;
                }

                for (int i = 0; i < count2; i++)
                {
                    mfLists[1][i].NewTrackNumber = (uint)(count1 + 1 + i);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Analysing directories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        private void LoadMFList(List<MusicFile> mfl, string dirName)
        {

            foreach (string fileName in Directory.GetFiles(dirName))
            {
                TagLib.File tf = null;

                try
                {
                    tf = TagLib.File.Create(fileName);
                }
                catch (TagLib.UnsupportedFormatException) { continue; }

                if (tf.Tag.Title != null)
                {
                    MusicFile mf = new MusicFile();
                    mf.FileName = fileName;
                    mf.Title = tf.Tag.Title;
                    mf.TrackNumber = tf.Tag.Track;
                    mfl.Add(mf);
                }
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string dirOut = dirOutTextBox.Text.Trim();
                string dir1 = dir1TextBox.Text.Trim();
                string dir2 = dir2TextBox.Text.Trim();

                if (dirOut == string.Empty)
                {
                    throw (new Exception("Output directory must be specified"));
                }

                if (dir1 == string.Empty || dir2 == string.Empty)
                {
                    throw (new Exception("Source directories must be specified"));
                }

                if (dirOut == dir1 || dirOut == dir2 || dir1 == dir2)
                {
                    throw (new Exception("Directories must be different"));
                }

                for (int i = 0; i < mfLists[0].Count; i++)
                {
                    string fileName = mfLists[0][i].FileName;
                    string baseName = Path.GetFileName(fileName);
                    string extension = Path.GetExtension(fileName);
                    string title = mfLists[0][i].Title;
                    title = title.Replace("?", "¿");
                    title = title.Replace("/", "-");
                    uint newTrackNumber = mfLists[0][i].NewTrackNumber;
                    //string newName = string.Format(@"{0}\{1}", dirOut, baseName);
                    string newName = string.Format(@"{0}\{1:D3} {2}{3}", dirOut, newTrackNumber, title, extension);
                    System.IO.File.Copy(fileName, newName, true);
                    TagLib.File tf = TagLib.File.Create(newName);
                    tf.Tag.Track = mfLists[0][i].NewTrackNumber;
                    tf.Tag.TrackCount = (uint)(mfLists[0].Count + mfLists[1].Count);
                    tf.Tag.Disc = 1;
                    tf.Tag.DiscCount = 1;
                    tf.Save();
                }

                for (int i = 0; i < mfLists[1].Count; i++)
                {
                    string fileName = mfLists[1][i].FileName;
                    string baseName = Path.GetFileName(fileName);
                    string extension = Path.GetExtension(fileName);
                    string title = mfLists[1][i].Title;
                    title = title.Replace("?", "¿");
                    title = title.Replace("/", "-");
                    uint newTrackNumber = mfLists[1][i].NewTrackNumber;
                    //string newName = string.Format(@"{0}\{1}", dirOut, baseName);
                    string newName = string.Format(@"{0}\{1:D3} {2}{3}", dirOut, newTrackNumber, title, extension);
                    System.IO.File.Copy(fileName, newName, true);
                    TagLib.File tf = TagLib.File.Create(newName);
                    tf.Tag.Track = mfLists[1][i].NewTrackNumber;
                    tf.Tag.TrackCount = (uint)(mfLists[0].Count + mfLists[1].Count);
                    tf.Tag.Disc = 1;
                    tf.Tag.DiscCount = 1;
                    tf.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Executing changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }




    }
}
