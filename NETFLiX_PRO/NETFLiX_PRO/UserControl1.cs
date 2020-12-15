using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NETFLiX_PRO
{
    public partial class UserControl1 : UserControl
    {
        DataSet ds = new DataSet();
        public UserControl1()
        {
            InitializeComponent();

        }

        private void listbutton_Click(object sender, EventArgs e)
        {
            ds.ReadXml("NETFLIX_TOP.xml");
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttonexport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    this.dataGridView1.DataSource = ds.Tables[0];

                    StringBuilder sb = new StringBuilder();

                    string[] columnNames = ds.Tables[0].Columns.Cast<DataColumn>().
                                                      Select(column => column.ColumnName).
                                                      ToArray();
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                        ToArray();
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }

            }

        }
    }
}
