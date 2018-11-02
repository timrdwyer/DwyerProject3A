namespace TDwyerProj3A
{
    partial class TdwyerProj3B
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentAmt = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtMnthsInYr = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Payment Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Length of Loan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Months in a year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mortgage Principal";
            // 
            // txtPaymentAmt
            // 
            this.txtPaymentAmt.Location = new System.Drawing.Point(216, 42);
            this.txtPaymentAmt.Name = "txtPaymentAmt";
            this.txtPaymentAmt.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentAmt.TabIndex = 4;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(216, 73);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            // 
            // txtMnthsInYr
            // 
            this.txtMnthsInYr.Location = new System.Drawing.Point(216, 107);
            this.txtMnthsInYr.Name = "txtMnthsInYr";
            this.txtMnthsInYr.Size = new System.Drawing.Size(100, 20);
            this.txtMnthsInYr.TabIndex = 6;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(216, 138);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 7;
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Location = new System.Drawing.Point(216, 171);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.Size = new System.Drawing.Size(100, 20);
            this.txtTotalInterest.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Interest Paid";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(216, 224);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // TdwyerProj3B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.txtMnthsInYr);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtPaymentAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TdwyerProj3B";
            this.Text = "Total Interest Calc";
            this.Load += new System.EventHandler(this.TdwyerProj3B_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaymentAmt;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtMnthsInYr;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalc;
    }
}

