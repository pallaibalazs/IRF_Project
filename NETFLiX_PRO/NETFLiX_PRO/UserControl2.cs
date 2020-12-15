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

namespace NETFLiX_PRO
{
    public partial class UserControl2 : UserControl
    {
        NETFLiX_PRO.Entities.ChartData context = new NETFLiX_PRO.Entities.ChartData();
        BindingList<ChartData> Charts = new BindingList<ChartData>();
        public UserControl2()
        {
            InitializeComponent();

            var xml = new XmlDocument();
            xml.Load("TV Shows - Netflix.xml");

            foreach (XmlElement element in xml.GetElementsByTagName("Titles"))
            {
                var title = new ChartData();
                Charts.Add(title);
                title.Titles = element.InnerText;
            }

            foreach (XmlElement element in xml.GetElementsByTagName("IMDB_Rating"))
            {
                var rating = new ChartData();
                Charts.Add(rating);
                rating.IMDB_Rating = Convert.ToDecimal(element.InnerText);
            }

        }
    }
}
