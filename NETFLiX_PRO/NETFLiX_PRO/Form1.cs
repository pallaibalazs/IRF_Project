﻿using NETFLiX_PRO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace NETFLiX_PRO
{
    public partial class Form1 : Form
    {
        ChartData context = new NETFLiX_PRO.Entities.ChartData();
        BindingList<ChartData> Charts = new BindingList<ChartData>();
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
        
    }
}
