using NETFLiX_PRO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace NETFLiX_PRO
{
    public partial class Form1 : AutoExit
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_bestseries_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl bestSeries = new UserControl1();
            panel1.Controls.Add(bestSeries);
            bestSeries.Dock = DockStyle.Fill;
        }

        private void buttonIMDB_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl ujdata = new UserControl2();
            panel1.Controls.Add(ujdata);
            ujdata.Dock = DockStyle.Fill;
        }

        private void buttonstock_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl stock = new UserControl3();
            panel1.Controls.Add(stock);
            stock.Dock = DockStyle.Fill;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetTimeOut();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akarsz lépni?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
        
    }
}
