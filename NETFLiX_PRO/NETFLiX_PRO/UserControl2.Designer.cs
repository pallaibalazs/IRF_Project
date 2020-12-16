namespace NETFLiX_PRO
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartIMDB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartIMDB)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIMDB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIMDB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIMDB.Legends.Add(legend1);
            this.chartIMDB.Location = new System.Drawing.Point(0, 41);
            this.chartIMDB.Name = "chartIMDB";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIMDB.Series.Add(series1);
            this.chartIMDB.Size = new System.Drawing.Size(643, 298);
            this.chartIMDB.TabIndex = 0;
            this.chartIMDB.Text = "chart1";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.chartIMDB);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(643, 384);
            ((System.ComponentModel.ISupportInitialize)(this.chartIMDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIMDB;
    }
}
