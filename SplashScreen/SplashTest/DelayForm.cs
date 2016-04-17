using SplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashTest
{
    public partial class DelayForm : Form
    {
        public DelayForm()
        {
            InitializeComponent();            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Thread.Sleep(3000); // Simulates delay
            SplashHandler.Close();

            // The window hides here so I tried to bring at back, without success
            this.Focus();
            this.BringToFront();
        }
    }
}
