namespace TI2
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
            this.bOpen = new System.Windows.Forms.Button();
            this.tKey = new System.Windows.Forms.TextBox();
            this.rEncript = new System.Windows.Forms.RichTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rFile = new System.Windows.Forms.RichTextBox();
            this.rKey = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(179, 470);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Открыть";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // tKey
            // 
            this.tKey.Location = new System.Drawing.Point(21, 43);
            this.tKey.Name = "tKey";
            this.tKey.Size = new System.Drawing.Size(715, 20);
            this.tKey.TabIndex = 2;
            // 
            // rEncript
            // 
            this.rEncript.Location = new System.Drawing.Point(480, 187);
            this.rEncript.Name = "rEncript";
            this.rEncript.Size = new System.Drawing.Size(422, 277);
            this.rEncript.TabIndex = 3;
            this.rEncript.Text = "";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(661, 470);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начальное состояние регистра ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Исходный файл";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(480, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зашифрованный файл";
            // 
            // rFile
            // 
            this.rFile.Location = new System.Drawing.Point(21, 187);
            this.rFile.Name = "rFile";
            this.rFile.Size = new System.Drawing.Size(422, 277);
            this.rFile.TabIndex = 8;
            this.rFile.Text = "";
            // 
            // rKey
            // 
            this.rKey.Location = new System.Drawing.Point(21, 90);
            this.rKey.Name = "rKey";
            this.rKey.Size = new System.Drawing.Size(881, 68);
            this.rKey.TabIndex = 9;
            this.rKey.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rKey);
            this.Controls.Add(this.rFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.rEncript);
            this.Controls.Add(this.tKey);
            this.Controls.Add(this.bOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.RichTextBox rKey;

        private System.Windows.Forms.RichTextBox rFile;

        private System.Windows.Forms.RichTextBox rDecript;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.RichTextBox rEncript;
        private System.Windows.Forms.TextBox tKey;

        #endregion
    }
}