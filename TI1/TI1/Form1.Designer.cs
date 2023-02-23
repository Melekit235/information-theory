namespace TI1
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
            this.rtdEnRail = new System.Windows.Forms.RichTextBox();
            this.rtbEnVi = new System.Windows.Forms.RichTextBox();
            this.bEncriptRail = new System.Windows.Forms.Button();
            this.tEnRail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbDeRail = new System.Windows.Forms.RichTextBox();
            this.rtbDeVi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bDeRail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tEnVi = new System.Windows.Forms.TextBox();
            this.bEnVi = new System.Windows.Forms.Button();
            this.tDeRail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tDeVi = new System.Windows.Forms.TextBox();
            this.bDeVi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtdEnRail
            // 
            this.rtdEnRail.Location = new System.Drawing.Point(12, 113);
            this.rtdEnRail.Name = "rtdEnRail";
            this.rtdEnRail.Size = new System.Drawing.Size(238, 121);
            this.rtdEnRail.TabIndex = 1;
            this.rtdEnRail.Text = "";
            // 
            // rtbEnVi
            // 
            this.rtbEnVi.Location = new System.Drawing.Point(12, 377);
            this.rtbEnVi.Name = "rtbEnVi";
            this.rtbEnVi.Size = new System.Drawing.Size(238, 121);
            this.rtbEnVi.TabIndex = 2;
            this.rtbEnVi.Text = "";
            // 
            // bEncriptRail
            // 
            this.bEncriptRail.Location = new System.Drawing.Point(65, 240);
            this.bEncriptRail.Name = "bEncriptRail";
            this.bEncriptRail.Size = new System.Drawing.Size(110, 33);
            this.bEncriptRail.TabIndex = 0;
            this.bEncriptRail.Text = "Шифрование";
            this.bEncriptRail.UseVisualStyleBackColor = true;
            this.bEncriptRail.Click += new System.EventHandler(this.bEncript_Click);
            // 
            // tEnRail
            // 
            this.tEnRail.Location = new System.Drawing.Point(12, 66);
            this.tEnRail.Name = "tEnRail";
            this.tEnRail.Size = new System.Drawing.Size(70, 20);
            this.tEnRail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шифрование";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изгородь";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Виженер";
            // 
            // rtbDeRail
            // 
            this.rtbDeRail.Location = new System.Drawing.Point(314, 113);
            this.rtbDeRail.Name = "rtbDeRail";
            this.rtbDeRail.Size = new System.Drawing.Size(238, 121);
            this.rtbDeRail.TabIndex = 8;
            this.rtbDeRail.Text = "";
            // 
            // rtbDeVi
            // 
            this.rtbDeVi.Location = new System.Drawing.Point(314, 377);
            this.rtbDeVi.Name = "rtbDeVi";
            this.rtbDeVi.Size = new System.Drawing.Size(238, 121);
            this.rtbDeVi.TabIndex = 9;
            this.rtbDeVi.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(314, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дешифрование";
            // 
            // bDeRail
            // 
            this.bDeRail.Location = new System.Drawing.Point(373, 241);
            this.bDeRail.Name = "bDeRail";
            this.bDeRail.Size = new System.Drawing.Size(121, 32);
            this.bDeRail.TabIndex = 11;
            this.bDeRail.Text = "Дешифрование";
            this.bDeRail.UseVisualStyleBackColor = true;
            this.bDeRail.Click += new System.EventHandler(this.bDeRail_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(314, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ключ";
            // 
            // tEnVi
            // 
            this.tEnVi.Location = new System.Drawing.Point(12, 320);
            this.tEnVi.Name = "tEnVi";
            this.tEnVi.Size = new System.Drawing.Size(70, 20);
            this.tEnVi.TabIndex = 13;
            // 
            // bEnVi
            // 
            this.bEnVi.Location = new System.Drawing.Point(65, 504);
            this.bEnVi.Name = "bEnVi";
            this.bEnVi.Size = new System.Drawing.Size(110, 33);
            this.bEnVi.TabIndex = 14;
            this.bEnVi.Text = "Шифрование";
            this.bEnVi.UseVisualStyleBackColor = true;
            this.bEnVi.Click += new System.EventHandler(this.bEnVi_Click);
            // 
            // tDeRail
            // 
            this.tDeRail.Location = new System.Drawing.Point(314, 66);
            this.tDeRail.Name = "tDeRail";
            this.tDeRail.Size = new System.Drawing.Size(70, 20);
            this.tDeRail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(314, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ключ";
            // 
            // tDeVi
            // 
            this.tDeVi.Location = new System.Drawing.Point(314, 320);
            this.tDeVi.Name = "tDeVi";
            this.tDeVi.Size = new System.Drawing.Size(70, 20);
            this.tDeVi.TabIndex = 17;
            // 
            // bDeVi
            // 
            this.bDeVi.Location = new System.Drawing.Point(373, 505);
            this.bDeVi.Name = "bDeVi";
            this.bDeVi.Size = new System.Drawing.Size(121, 32);
            this.bDeVi.TabIndex = 18;
            this.bDeVi.Text = "Дешифрование";
            this.bDeVi.UseVisualStyleBackColor = true;
            this.bDeVi.Click += new System.EventHandler(this.bDeVi_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bDeVi);
            this.Controls.Add(this.tDeVi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tDeRail);
            this.Controls.Add(this.bEnVi);
            this.Controls.Add(this.tEnVi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bDeRail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbDeVi);
            this.Controls.Add(this.rtbDeRail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tEnRail);
            this.Controls.Add(this.rtbEnVi);
            this.Controls.Add(this.rtdEnRail);
            this.Controls.Add(this.bEncriptRail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tEnVi;

        private System.Windows.Forms.TextBox tDeRail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tDeVi;
        private System.Windows.Forms.Button bDeVi;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button bEnVi;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDeRail;
        private System.Windows.Forms.RichTextBox rtbDeVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bDeRail;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox tEnRail;

        private System.Windows.Forms.Button bEncriptRail;
        private System.Windows.Forms.RichTextBox rtdEnRail;
        private System.Windows.Forms.RichTextBox rtbEnVi;

        #endregion
    }
}