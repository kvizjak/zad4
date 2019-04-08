namespace zad4
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
            this.inRecenica = new System.Windows.Forms.TextBox();
            this.inPrepis = new System.Windows.Forms.TextBox();
            this.outBrzina = new System.Windows.Forms.TextBox();
            this.outVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inRecenica
            // 
            this.inRecenica.Location = new System.Drawing.Point(97, 60);
            this.inRecenica.Name = "inRecenica";
            this.inRecenica.Size = new System.Drawing.Size(176, 20);
            this.inRecenica.TabIndex = 0;
            // 
            // inPrepis
            // 
            this.inPrepis.Location = new System.Drawing.Point(97, 103);
            this.inPrepis.Name = "inPrepis";
            this.inPrepis.Size = new System.Drawing.Size(176, 20);
            this.inPrepis.TabIndex = 1;
            this.inPrepis.TextChanged += new System.EventHandler(this.inPrepis_TextChanged);
            // 
            // outBrzina
            // 
            this.outBrzina.Location = new System.Drawing.Point(97, 146);
            this.outBrzina.Name = "outBrzina";
            this.outBrzina.Size = new System.Drawing.Size(176, 20);
            this.outBrzina.TabIndex = 2;
            // 
            // outVrijeme
            // 
            this.outVrijeme.Location = new System.Drawing.Point(97, 191);
            this.outVrijeme.Name = "outVrijeme";
            this.outVrijeme.Size = new System.Drawing.Size(106, 20);
            this.outVrijeme.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesi rečenicu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prepiši rečenicu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brzina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outVrijeme);
            this.Controls.Add(this.outBrzina);
            this.Controls.Add(this.inPrepis);
            this.Controls.Add(this.inRecenica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inRecenica;
        private System.Windows.Forms.TextBox inPrepis;
        private System.Windows.Forms.TextBox outBrzina;
        private System.Windows.Forms.TextBox outVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

