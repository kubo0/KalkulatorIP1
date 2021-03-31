
namespace KalkulatorIP1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IPTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.MaskTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastIPTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BroadcastTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstHostTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LastHostTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres IP: ";
            // 
            // IPTextBox1
            // 
            this.IPTextBox1.Location = new System.Drawing.Point(12, 27);
            this.IPTextBox1.Mask = "###\\.###\\.###\\.###";
            this.IPTextBox1.Name = "IPTextBox1";
            this.IPTextBox1.Size = new System.Drawing.Size(100, 23);
            this.IPTextBox1.TabIndex = 3;
            // 
            // MaskTextBox1
            // 
            this.MaskTextBox1.Location = new System.Drawing.Point(118, 27);
            this.MaskTextBox1.Mask = "###\\.###\\.###\\.###";
            this.MaskTextBox1.Name = "MaskTextBox1";
            this.MaskTextBox1.Size = new System.Drawing.Size(100, 23);
            this.MaskTextBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maska: ";
            // 
            // LastIPTextBox1
            // 
            this.LastIPTextBox1.Location = new System.Drawing.Point(224, 27);
            this.LastIPTextBox1.Mask = "###\\.###\\.###\\.###";
            this.LastIPTextBox1.Name = "LastIPTextBox1";
            this.LastIPTextBox1.ReadOnly = true;
            this.LastIPTextBox1.Size = new System.Drawing.Size(100, 23);
            this.LastIPTextBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres sieci:";
            // 
            // BroadcastTextBox1
            // 
            this.BroadcastTextBox1.Location = new System.Drawing.Point(330, 27);
            this.BroadcastTextBox1.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox1.Name = "BroadcastTextBox1";
            this.BroadcastTextBox1.ReadOnly = true;
            this.BroadcastTextBox1.Size = new System.Drawing.Size(100, 23);
            this.BroadcastTextBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres rozgłoszeniowy:";
            // 
            // FirstHostTextBox1
            // 
            this.FirstHostTextBox1.Location = new System.Drawing.Point(118, 73);
            this.FirstHostTextBox1.Mask = "###\\.###\\.###\\.###";
            this.FirstHostTextBox1.Name = "FirstHostTextBox1";
            this.FirstHostTextBox1.Size = new System.Drawing.Size(100, 23);
            this.FirstHostTextBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pierwszy host:";
            // 
            // LastHostTextBox1
            // 
            this.LastHostTextBox1.Location = new System.Drawing.Point(224, 73);
            this.LastHostTextBox1.Mask = "###\\.###\\.###\\.###";
            this.LastHostTextBox1.Name = "LastHostTextBox1";
            this.LastHostTextBox1.Size = new System.Drawing.Size(100, 23);
            this.LastHostTextBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ostatni host:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 138);
            this.Controls.Add(this.LastHostTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FirstHostTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BroadcastTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastIPTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaskTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox IPTextBox1;
        private System.Windows.Forms.MaskedTextBox MaskTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox LastIPTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox FirstHostTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox LastHostTextBox1;
        private System.Windows.Forms.Label label6;
    }
}

