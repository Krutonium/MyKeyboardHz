using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKeyboardHz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static DateTime startTime = DateTime.Now;
        private static DateTime endTime = DateTime.Now;
        private static int shortestPress = int.MaxValue;

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { return; }
            startTime = DateTime.Now;
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { return; }
            endTime = DateTime.Now;
            var time = endTime - startTime;
            lblResults.Text += Environment.NewLine + time.Milliseconds.ToString();
            if(time.Milliseconds < shortestPress)
            {
                shortestPress = time.Milliseconds;
            }
            lblScanRate.Text = "Estimated Scan Rate: " + Environment.NewLine + (1000f / shortestPress) + "Hz";
        }
    }
}
