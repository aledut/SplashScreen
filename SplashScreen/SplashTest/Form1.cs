using SplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SplashHandler.Close();
        }
    }
}
