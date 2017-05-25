using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundPlayer
{
    public partial class Form1 : Form
    {

        private PickKey key;
        private Error err;
        private Save save;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Text = "Sound Board";
            this.AutoScroll = true;
            this.MinimumSize = new Size(514, 360);
            this.MaximumSize = new Size(514, 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button name = (Button)sender;
            key = new PickKey(name);
            key.ShowDialog();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result =  openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Find out how to know witch one to use
                Button name = (Button)sender;
                int number = Int32.Parse(name.Name);
                AreaFileText[number].Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakeNewLable();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());
            for (int i = 0; i < counter; i++) {
                if (AreaButton1[i].Name == e.KeyCode.ToString()) {
                    try
                    {
                        AreaPlayer = new System.Media.SoundPlayer(AreaFileText[i].Text.ToString());
                        AreaPlayer.Play();
                    }
                    catch (Exception x) {
                        err = new Error(x.Message);
                        err.ShowDialog();
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            err = new Error("Woirk In Progress");
            err.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            err = new Error("Woirk In Progress");
            err.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save = new Save();
            save.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            err = new Error("Error0X001F: Wrong File Type");
            err.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
