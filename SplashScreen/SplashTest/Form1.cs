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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SplashHandler.Start(); Thread.Sleep(300);
            SplashHandler.BringTop();
            SplashHandler.ChangeText("Carregando...");
            
            var x = new DelayForm();
            x.ShowDialog();  
        }
    }
}
