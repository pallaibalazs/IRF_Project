namespace NETFLiX_PRO
{
    partial class UserControl1
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
            this.listbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonexport = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listbutton
            // 
            this.listbutton.Location = new System.Drawing.Point(0, 17);
            this.listbutton.Name = "listbutton";
            this.listbutton.Size = new System.Drawing.Size(628, 23);
            this.listbutton.TabIndex = 0;
            this.listbutton.Text = "Sorozatok listázása";
            this.listbutton.UseVisualStyleBackColor = true;
            this.listbutton.Click += new System.EventHandler(this.listbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 371);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonexport
            // 
            this.buttonexport.Location = new System.Drawing.Point(487, 356);
            this.buttonexport.Name = "buttonexport";
            this.buttonexport.Size = new System.Drawing.Size(133, 61);
            this.buttonexport.TabIndex = 2;
            this.buttonexport.Text = "Exportálás (CSV)";
            this.buttonexport.UseVisualStyleBackColor = true;
            this.buttonexport.Click += new System.EventHandler(this.buttonexport_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 4;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonexport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listbutton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(628, 431);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonexport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
