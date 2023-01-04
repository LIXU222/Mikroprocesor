namespace _8086sim
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
            this.AX_textBox = new System.Windows.Forms.TextBox();
            this.BX_textBox = new System.Windows.Forms.TextBox();
            this.CX_textBox = new System.Windows.Forms.TextBox();
            this.DX_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AX_textBox
            // 
            this.AX_textBox.Location = new System.Drawing.Point(12, 64);
            this.AX_textBox.Name = "AX_textBox";
            this.AX_textBox.ReadOnly = true;
            this.AX_textBox.Size = new System.Drawing.Size(100, 20);
            this.AX_textBox.TabIndex = 0;
            // 
            // BX_textBox
            // 
            this.BX_textBox.Location = new System.Drawing.Point(118, 64);
            this.BX_textBox.Name = "BX_textBox";
            this.BX_textBox.ReadOnly = true;
            this.BX_textBox.Size = new System.Drawing.Size(100, 20);
            this.BX_textBox.TabIndex = 1;
            // 
            // CX_textBox
            // 
            this.CX_textBox.Location = new System.Drawing.Point(224, 64);
            this.CX_textBox.Name = "CX_textBox";
            this.CX_textBox.ReadOnly = true;
            this.CX_textBox.Size = new System.Drawing.Size(100, 20);
            this.CX_textBox.TabIndex = 2;
            // 
            // DX_textBox
            // 
            this.DX_textBox.Location = new System.Drawing.Point(330, 64);
            this.DX_textBox.Name = "DX_textBox";
            this.DX_textBox.ReadOnly = true;
            this.DX_textBox.Size = new System.Drawing.Size(100, 20);
            this.DX_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "AX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Random Registers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Interact";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DX_textBox);
            this.Controls.Add(this.CX_textBox);
            this.Controls.Add(this.BX_textBox);
            this.Controls.Add(this.AX_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AX_textBox;
        private System.Windows.Forms.TextBox BX_textBox;
        private System.Windows.Forms.TextBox CX_textBox;
        private System.Windows.Forms.TextBox DX_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

