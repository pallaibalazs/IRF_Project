using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NETFLiX_PRO.Entities;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace NETFLiX_PRO
{
    public partial class UserControl3 : UserControl
    {
        NETFLiX_PRO.Entities.Stock context = new NETFLiX_PRO.Entities.Stock();
        BindingList<Stock> Stocks = new BindingList<Stock>();
        public UserControl3()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("NETFLIXSTOCK.xml");

            XmlNodeList time = xDoc.GetElementsByTagName("Time");
            XmlNodeList opn = xDoc.GetElementsByTagName("Open");


            for (int i = 0; i < 10; i++)
            {
                var stock = new Stock();
                Stocks.Add(stock);

                stock.Datum = DateTime.Parse(time[i].InnerText);
                stock.Nyito_ertek = decimal.Parse(opn[i].InnerText);

            }

            dataGridView1.DataSource = Stocks;

            chart1.DataSource = Stocks;

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Datum";
            series.YValueMembers = "Nyito_ertek";
            series.BorderWidth = 4;

            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }
    }
}
