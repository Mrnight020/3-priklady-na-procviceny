
namespace Priklady_na_proscviceni_na_30._01
{
    partial class Ukol3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prevod = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.Label();
            this.labelcifernysoucet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 201);
            this.textBox1.TabIndex = 0;
            // 
            // prevod
            // 
            this.prevod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prevod.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevod.Location = new System.Drawing.Point(194, 249);
            this.prevod.Name = "prevod";
            this.prevod.Size = new System.Drawing.Size(112, 67);
            this.prevod.TabIndex = 1;
            this.prevod.Text = "Převod";
            this.prevod.UseVisualStyleBackColor = false;
            this.prevod.Click += new System.EventHandler(this.prevod_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(416, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 100);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "lichá čísla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "minimální číslo";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(462, 299);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(23, 17);
            this.min.TabIndex = 5;
            this.min.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "součin čísel mimo <5,20)";
            // 
            // interval
            // 
            this.interval.AutoSize = true;
            this.interval.Location = new System.Drawing.Point(504, 334);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(23, 17);
            this.interval.TabIndex = 7;
            this.interval.Text = "---";
            // 
            // labelcifernysoucet
            // 
            this.labelcifernysoucet.AutoSize = true;
            this.labelcifernysoucet.Location = new System.Drawing.Point(504, 366);
            this.labelcifernysoucet.Name = "labelcifernysoucet";
            this.labelcifernysoucet.Size = new System.Drawing.Size(23, 17);
            this.labelcifernysoucet.TabIndex = 9;
            this.labelcifernysoucet.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ciferny součet maxima :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zadej sem celá čísla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(220, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 52);
            this.label6.TabIndex = 11;
            this.label6.Text = "3.Úkol";
            // 
            // Ukol3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(596, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelcifernysoucet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prevod);
            this.Controls.Add(this.textBox1);
            this.Name = "Ukol3";
            this.Text = "Ukol3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button prevod;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label interval;
        private System.Windows.Forms.Label labelcifernysoucet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}