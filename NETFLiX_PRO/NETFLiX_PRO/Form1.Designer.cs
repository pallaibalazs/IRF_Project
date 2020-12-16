namespace NETFLiX_PRO
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_bestseries = new System.Windows.Forms.Button();
            this.buttonIMDB = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonstock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(159, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 403);
            this.panel1.TabIndex = 0;
            // 
            // button_bestseries
            // 
            this.button_bestseries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_bestseries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_bestseries.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_bestseries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_bestseries.Location = new System.Drawing.Point(13, 12);
            this.button_bestseries.Name = "button_bestseries";
            this.button_bestseries.Size = new System.Drawing.Size(140, 65);
            this.button_bestseries.TabIndex = 1;
            this.button_bestseries.Text = "Legnézettebb sorozatok";
            this.button_bestseries.UseVisualStyleBackColor = false;
            this.button_bestseries.Click += new System.EventHandler(this.button_bestseries_Click);
            // 
            // buttonIMDB
            // 
            this.buttonIMDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonIMDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIMDB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIMDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIMDB.Location = new System.Drawing.Point(13, 101);
            this.buttonIMDB.Name = "buttonIMDB";
            this.buttonIMDB.Size = new System.Drawing.Size(140, 65);
            this.buttonIMDB.TabIndex = 2;
            this.buttonIMDB.Text = "IMDB értékelések";
            this.buttonIMDB.UseVisualStyleBackColor = false;
            this.buttonIMDB.Click += new System.EventHandler(this.buttonIMDB_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Automatikus kilépés 5 perc inaktivitás után";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonstock
            // 
            this.buttonstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstock.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonstock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonstock.Location = new System.Drawing.Point(13, 186);
            this.buttonstock.Name = "buttonstock";
            this.buttonstock.Size = new System.Drawing.Size(140, 65);
            this.buttonstock.TabIndex = 4;
            this.buttonstock.Text = "NETFLIX részvényadatok";
            this.buttonstock.UseVisualStyleBackColor = false;
            this.buttonstock.Click += new System.EventHandler(this.buttonstock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonstock);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonIMDB);
            this.Controls.Add(this.button_bestseries);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_bestseries;
        private System.Windows.Forms.Button buttonIMDB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonstock;
    }
}

