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
        private static List<int> times = new List<int>();
        private static List<float> scanrates = new List<float>();
        private static int count = 0;

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
            if(time.Milliseconds == 0) { return; };
            if(count > 10)
            {
                count = 0;
                lblResults.Text = "Results: "; 
            }
            lblResults.Text += Environment.NewLine + time.Milliseconds.ToString() + " MS : " + e.KeyCode;
            count += 1;
            if(time.Milliseconds < shortestPress)
            {
                shortestPress = time.Milliseconds;
            }
            times.Add(time.Milliseconds);
            scanrates.Add(1000 / time.Milliseconds);
            updateCounts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void updateCounts()
        {
            lblScanRate.Text = "Estimated Scan Rate: " + Environment.NewLine +
                               (1000f / shortestPress) + " Hz" + Environment.NewLine +
                               "Average Scan Rate: " + Environment.NewLine +
                               scanrates.Average() + " Hz" + Environment.NewLine +
                               "Average Keypress MS: " + Environment.NewLine +
                               times.Average() + " MS";
        }
    }
}
