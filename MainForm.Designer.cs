namespace DiscMerge
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dir1TextBox = new System.Windows.Forms.TextBox();
            this.dir2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dir1BrowseButton = new System.Windows.Forms.Button();
            this.dir2BrowseButton = new System.Windows.Forms.Button();
            this.dir1GridView = new System.Windows.Forms.DataGridView();
            this.dir2GridView = new System.Windows.Forms.DataGridView();
            this.analyseButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.dirOutBrowseButton = new System.Windows.Forms.Button();
            this.dirOutTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dir1GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dir2GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory 1";
            // 
            // dir1TextBox
            // 
            this.dir1TextBox.Location = new System.Drawing.Point(15, 26);
            this.dir1TextBox.Name = "dir1TextBox";
            this.dir1TextBox.Size = new System.Drawing.Size(255, 20);
            this.dir1TextBox.TabIndex = 1;
            // 
            // dir2TextBox
            // 
            this.dir2TextBox.Location = new System.Drawing.Point(414, 26);
            this.dir2TextBox.Name = "dir2TextBox";
            this.dir2TextBox.Size = new System.Drawing.Size(255, 20);
            this.dir2TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Directory 2";
            // 
            // dir1BrowseButton
            // 
            this.dir1BrowseButton.Location = new System.Drawing.Point(276, 26);
            this.dir1BrowseButton.Name = "dir1BrowseButton";
            this.dir1BrowseButton.Size = new System.Drawing.Size(36, 19);
            this.dir1BrowseButton.TabIndex = 2;
            this.dir1BrowseButton.Text = "...";
            this.dir1BrowseButton.UseVisualStyleBackColor = true;
            this.dir1BrowseButton.Click += new System.EventHandler(this.dirBrowseButton_Click);
            // 
            // dir2BrowseButton
            // 
            this.dir2BrowseButton.Location = new System.Drawing.Point(672, 26);
            this.dir2BrowseButton.Name = "dir2BrowseButton";
            this.dir2BrowseButton.Size = new System.Drawing.Size(36, 19);
            this.dir2BrowseButton.TabIndex = 4;
            this.dir2BrowseButton.Text = "...";
            this.dir2BrowseButton.UseVisualStyleBackColor = true;
            this.dir2BrowseButton.Click += new System.EventHandler(this.dirBrowseButton_Click);
            // 
            // dir1GridView
            // 
            this.dir1GridView.AllowUserToAddRows = false;
            this.dir1GridView.AllowUserToDeleteRows = false;
            this.dir1GridView.AllowUserToResizeRows = false;
            this.dir1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dir1GridView.Location = new System.Drawing.Point(15, 66);
            this.dir1GridView.Name = "dir1GridView";
            this.dir1GridView.ReadOnly = true;
            this.dir1GridView.RowHeadersVisible = false;
            this.dir1GridView.Size = new System.Drawing.Size(360, 260);
            this.dir1GridView.TabIndex = 6;
            // 
            // dir2GridView
            // 
            this.dir2GridView.AllowUserToAddRows = false;
            this.dir2GridView.AllowUserToDeleteRows = false;
            this.dir2GridView.AllowUserToResizeRows = false;
            this.dir2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dir2GridView.Location = new System.Drawing.Point(414, 66);
            this.dir2GridView.Name = "dir2GridView";
            this.dir2GridView.ReadOnly = true;
            this.dir2GridView.RowHeadersVisible = false;
            this.dir2GridView.Size = new System.Drawing.Size(360, 260);
            this.dir2GridView.TabIndex = 7;
            // 
            // analyseButton
            // 
            this.analyseButton.Location = new System.Drawing.Point(12, 379);
            this.analyseButton.Name = "analyseButton";
            this.analyseButton.Size = new System.Drawing.Size(75, 23);
            this.analyseButton.TabIndex = 8;
            this.analyseButton.Text = "Analyse";
            this.analyseButton.UseVisualStyleBackColor = true;
            this.analyseButton.Click += new System.EventHandler(this.analyseButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(103, 379);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 9;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // dirOutBrowseButton
            // 
            this.dirOutBrowseButton.Location = new System.Drawing.Point(273, 342);
            this.dirOutBrowseButton.Name = "dirOutBrowseButton";
            this.dirOutBrowseButton.Size = new System.Drawing.Size(36, 19);
            this.dirOutBrowseButton.TabIndex = 11;
            this.dirOutBrowseButton.Text = "...";
            this.dirOutBrowseButton.UseVisualStyleBackColor = true;
            this.dirOutBrowseButton.Click += new System.EventHandler(this.dirBrowseButton_Click);
            // 
            // dirOutTextBox
            // 
            this.dirOutTextBox.Location = new System.Drawing.Point(12, 342);
            this.dirOutTextBox.Name = "dirOutTextBox";
            this.dirOutTextBox.Size = new System.Drawing.Size(255, 20);
            this.dirOutTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 456);
            this.Controls.Add(this.dirOutBrowseButton);
            this.Controls.Add(this.dirOutTextBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.analyseButton);
            this.Controls.Add(this.dir2GridView);
            this.Controls.Add(this.dir1GridView);
            this.Controls.Add(this.dir2BrowseButton);
            this.Controls.Add(this.dir1BrowseButton);
            this.Controls.Add(this.dir2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dir1TextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DiscMerge";
            ((System.ComponentModel.ISupportInitialize)(this.dir1GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dir2GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dir1TextBox;
        private System.Windows.Forms.TextBox dir2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dir1BrowseButton;
        private System.Windows.Forms.Button dir2BrowseButton;
        private System.Windows.Forms.DataGridView dir1GridView;
        private System.Windows.Forms.DataGridView dir2GridView;
        private System.Windows.Forms.Button analyseButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button dirOutBrowseButton;
        private System.Windows.Forms.TextBox dirOutTextBox;
    }
}

