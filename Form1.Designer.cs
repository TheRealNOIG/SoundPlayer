namespace SoundPlayer
{
    partial class Form1
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


        private System.Windows.Forms.GroupBox[] Area = new System.Windows.Forms.GroupBox[100];
        private System.Windows.Forms.Button[] AreaButton1 = new System.Windows.Forms.Button[100];
        private System.Windows.Forms.Button[] AreaButton2 = new System.Windows.Forms.Button[100];
        private System.Windows.Forms.TextBox[] AreaFileText = new System.Windows.Forms.TextBox[100];
        private System.Windows.Forms.OpenFileDialog AreaOpenFileDialog;
        private System.Media.SoundPlayer AreaPlayer = new System.Media.SoundPlayer();

        int counter = 0;

        public void MakeNewLable() {
            if (counter < 100)
            {
                //Make theobjects
                this.SuspendLayout();
                this.Area[counter] = new System.Windows.Forms.GroupBox();
                this.AreaButton1[counter] = new System.Windows.Forms.Button();
                this.AreaButton2[counter] = new System.Windows.Forms.Button();
                this.AreaFileText[counter] = new System.Windows.Forms.TextBox();
                this.AreaOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
                //SuspendLyout so we can draw on it
                this.Area[counter].SuspendLayout();
                //Area
                this.Area[counter].Controls.Add(this.AreaFileText[counter]);
                this.Area[counter].Controls.Add(this.AreaButton2[counter]);
                this.Area[counter].Controls.Add(this.AreaButton1[counter]);
                this.Area[counter].Location = new System.Drawing.Point(12, (counter * 50) + 46);
                this.Area[counter].Name = "Label" + counter;
                this.Area[counter].Size = new System.Drawing.Size(461, 47);
                this.Area[counter].TabIndex = 0;
                this.Area[counter].TabStop = false;
                this.Area[counter].Text = "Label" + counter;
                //FileText
                this.AreaFileText[counter].Location = new System.Drawing.Point(47, 18);
                this.AreaFileText[counter].Name = "FileText" + counter;
                this.AreaFileText[counter].Size = new System.Drawing.Size(355, 20);
                this.AreaFileText[counter].TabIndex = 2;
                // Button1
                this.AreaButton1[counter].Location = new System.Drawing.Point(6, 18);
                this.AreaButton1[counter].Name = counter.ToString();
                this.AreaButton1[counter].Size = new System.Drawing.Size(34, 23);
                this.AreaButton1[counter].TabIndex = 0;
                this.AreaButton1[counter].Text = "Key";
                this.AreaButton1[counter].UseVisualStyleBackColor = true;
                this.AreaButton1[counter].Click += new System.EventHandler(this.button1_Click);
                // button2
                this.AreaButton2[counter].Location = new System.Drawing.Point(408, 18);
                this.AreaButton2[counter].Name = counter.ToString();
                this.AreaButton2[counter].Size = new System.Drawing.Size(47, 23);
                this.AreaButton2[counter].TabIndex = 1;
                this.AreaButton2[counter].Text = "File";
                this.AreaButton2[counter].UseVisualStyleBackColor = true;
                this.AreaButton2[counter].Click += new System.EventHandler(this.button2_Click);
                //FileReader
                this.AreaOpenFileDialog.FileName = "openFileDialog" + counter;
                //Finish
                this.Controls.Add(this.Area[counter]);
                this.Area[counter].ResumeLayout(false);
                this.ResumeLayout(false);
                this.AutoScroll = true;
                counter++;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "New Label";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Here To Start Playing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 322);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

