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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(159, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 426);
            this.panel1.TabIndex = 0;
            // 
            // button_bestseries
            // 
            this.button_bestseries.Location = new System.Drawing.Point(13, 12);
            this.button_bestseries.Name = "button_bestseries";
            this.button_bestseries.Size = new System.Drawing.Size(140, 57);
            this.button_bestseries.TabIndex = 1;
            this.button_bestseries.Text = "Legnézettebb sorozatok";
            this.button_bestseries.UseVisualStyleBackColor = true;
            this.button_bestseries.Click += new System.EventHandler(this.button_bestseries_Click);
            // 
            // buttonIMDB
            // 
            this.buttonIMDB.Location = new System.Drawing.Point(13, 91);
            this.buttonIMDB.Name = "buttonIMDB";
            this.buttonIMDB.Size = new System.Drawing.Size(140, 57);
            this.buttonIMDB.TabIndex = 2;
            this.buttonIMDB.Text = "IMDB értékelések";
            this.buttonIMDB.UseVisualStyleBackColor = true;
            this.buttonIMDB.Click += new System.EventHandler(this.buttonIMDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIMDB);
            this.Controls.Add(this.button_bestseries);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_bestseries;
        private System.Windows.Forms.Button buttonIMDB;
    }
}

