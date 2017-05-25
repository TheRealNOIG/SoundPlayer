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
    public partial class PickKey : Form
    {
        Button button;

        public PickKey(Button button)
        {
            InitializeComponent();
            this.Name = "Pick Key";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.button = button;
        }

        private void PickKey_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            button.Text = e.KeyCode.ToString();
            button.Name = e.KeyCode.ToString();
            this.Close();
        }

        private void PickKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
