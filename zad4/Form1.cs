using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Diagnostics.Stopwatch sat = new System.Diagnostics.Stopwatch();
        private void inPrepis_TextChanged(object sender, EventArgs e)
        {
            sat.Start();
            if (inRecenica.Text == inPrepis.Text)
            {
                
                sat.Stop();
                string vrijeme = sat.Elapsed.ToString();
                outVrijeme.Text = vrijeme;

                int vrijemeSekunde = sat.Elapsed.Seconds;
                double brzina = inPrepis.Text.Length / vrijemeSekunde;
                outBrzina.Text = brzina.ToString() + " znakova/sec";
                    
            }
        }
    }
}
