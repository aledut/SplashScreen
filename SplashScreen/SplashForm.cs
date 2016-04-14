using System;
using System.Windows.Forms;

namespace SplashScreen
{
    internal partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            label2.Text = "";
        }

        public void KillMe(object o, EventArgs e)
        {
            this.Close();
            this.Cursor = Cursors.Default; ;
        }

        public void BringTop(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.TopMost = true;
        }

        public void ChangeText(object sender, EventArgs e)
        {
            label2.Text = sender as String;
        }
    }
}
