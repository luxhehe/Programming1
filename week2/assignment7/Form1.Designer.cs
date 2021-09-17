
namespace assignment7
{
    partial class assignment7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartkm = new System.Windows.Forms.TextBox();
            this.txtEndkm = new System.Windows.Forms.TextBox();
            this.txtPricePerKm = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPriceExclVAT = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblPriceInclVAT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start km";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "End km";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price / km";
            // 
            // txtStartkm
            // 
            this.txtStartkm.Location = new System.Drawing.Point(189, 35);
            this.txtStartkm.Name = "txtStartkm";
            this.txtStartkm.Size = new System.Drawing.Size(122, 22);
            this.txtStartkm.TabIndex = 3;
            // 
            // txtEndkm
            // 
            this.txtEndkm.Location = new System.Drawing.Point(189, 68);
            this.txtEndkm.Name = "txtEndkm";
            this.txtEndkm.Size = new System.Drawing.Size(122, 22);
            this.txtEndkm.TabIndex = 4;
            // 
            // txtPricePerKm
            // 
            this.txtPricePerKm.Location = new System.Drawing.Point(189, 102);
            this.txtPricePerKm.Name = "txtPricePerKm";
            this.txtPricePerKm.Size = new System.Drawing.Size(122, 22);
            this.txtPricePerKm.TabIndex = 5;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(372, 33);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 6;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(372, 102);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price excl VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price incl VAT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPriceExclVAT
            // 
            this.lblPriceExclVAT.AutoSize = true;
            this.lblPriceExclVAT.Location = new System.Drawing.Point(32, 305);
            this.lblPriceExclVAT.Name = "lblPriceExclVAT";
            this.lblPriceExclVAT.Size = new System.Drawing.Size(46, 17);
            this.lblPriceExclVAT.TabIndex = 12;
            this.lblPriceExclVAT.Text = "label7";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(165, 304);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(46, 17);
            this.lblVAT.TabIndex = 13;
            this.lblVAT.Text = "label8";
            // 
            // lblPriceInclVAT
            // 
            this.lblPriceInclVAT.AutoSize = true;
            this.lblPriceInclVAT.Location = new System.Drawing.Point(369, 304);
            this.lblPriceInclVAT.Name = "lblPriceInclVAT";
            this.lblPriceInclVAT.Size = new System.Drawing.Size(46, 17);
            this.lblPriceInclVAT.TabIndex = 14;
            this.lblPriceInclVAT.Text = "label9";
            // 
            // assignment7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 342);
            this.Controls.Add(this.lblPriceInclVAT);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPriceExclVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.txtPricePerKm);
            this.Controls.Add(this.txtEndkm);
            this.Controls.Add(this.txtStartkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "assignment7";
            this.Text = "assignment7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartkm;
        private System.Windows.Forms.TextBox txtEndkm;
        private System.Windows.Forms.TextBox txtPricePerKm;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPriceExclVAT;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblPriceInclVAT;
    }
}

