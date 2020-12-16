using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using NETFLiX_PRO.Entities;
using System.Windows.Forms.DataVisualization.Charting;

namespace NETFLiX_PRO
{
    public partial class UserControl2 : UserControl
    {
        NETFLiX_PRO.Entities.ChartData context = new NETFLiX_PRO.Entities.ChartData();
        BindingList<ChartData> Charts = new BindingList<ChartData>();

        public UserControl2()
        {
            InitializeComponent();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("NETFLIX_DATA.xml");

            XmlNodeList titles = xDoc.GetElementsByTagName("Titles");
            XmlNodeList imdb = xDoc.GetElementsByTagName("IMDB_Rating");


            for (int i = 0; i < 50; i++)
            {
                var chart = new ChartData();
                Charts.Add(chart);

                chart.Titles = titles[i].InnerText;
                chart.IMDB = decimal.Parse(imdb[i].InnerText);

            }
            
            chartIMDB.DataSource = Charts;

            var series = chartIMDB.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "Titles";
            series.YValueMembers = "IMDB";
            series.BorderWidth = 3;

            var legend = chartIMDB.Legends[0];
            legend.Enabled = false;

            var chartArea = chartIMDB.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

        }
    }
}
