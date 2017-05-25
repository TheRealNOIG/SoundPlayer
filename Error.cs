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
    public partial class Error : Form
    {

        public Error(string err)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.richTextBox1.Text = err;
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
