
namespace Priklady_na_proscviceni_na_30._01
{
    partial class Ukol1
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
            this.prevod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelmax = new System.Windows.Forms.Label();
            this.labelmaxipocet = new System.Windows.Forms.Label();
            this.labelmaxposledni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelminprvni = new System.Windows.Forms.Label();
            this.labelminpocet = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // prevod
            // 
            this.prevod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prevod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevod.Location = new System.Drawing.Point(306, 264);
            this.prevod.Name = "prevod";
            this.prevod.Size = new System.Drawing.Size(120, 65);
            this.prevod.TabIndex = 0;
            this.prevod.Text = "Převod";
            this.prevod.UseVisualStyleBackColor = false;
            this.prevod.Click += new System.EventHandler(this.prevod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(220, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "<-15,60)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(454, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 292);
            this.listBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 194);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(213, 233);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(23, 17);
            this.labelmax.TabIndex = 5;
            this.labelmax.Text = "---";
            // 
            // labelmaxipocet
            // 
            this.labelmaxipocet.AutoSize = true;
            this.labelmaxipocet.Location = new System.Drawing.Point(213, 264);
            this.labelmaxipocet.Name = "labelmaxipocet";
            this.labelmaxipocet.Size = new System.Drawing.Size(23, 17);
            this.labelmaxipocet.TabIndex = 6;
            this.labelmaxipocet.Text = "---";
            // 
            // labelmaxposledni
            // 
            this.labelmaxposledni.AutoSize = true;
            this.labelmaxposledni.Location = new System.Drawing.Point(213, 296);
            this.labelmaxposledni.Name = "labelmaxposledni";
            this.labelmaxposledni.Size = new System.Drawing.Size(23, 17);
            this.labelmaxposledni.TabIndex = 7;
            this.labelmaxposledni.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pořadí prvního minimum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Počet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Minimum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pořadí posledního max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Počet max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Maximum";
            // 
            // labelminprvni
            // 
            this.labelminprvni.AutoSize = true;
            this.labelminprvni.Location = new System.Drawing.Point(213, 397);
            this.labelminprvni.Name = "labelminprvni";
            this.labelminprvni.Size = new System.Drawing.Size(23, 17);
            this.labelminprvni.TabIndex = 16;
            this.labelminprvni.Text = "---";
            // 
            // labelminpocet
            // 
            this.labelminpocet.AutoSize = true;
            this.labelminpocet.Location = new System.Drawing.Point(213, 365);
            this.labelminpocet.Name = "labelminpocet";
            this.labelminpocet.Size = new System.Drawing.Size(23, 17);
            this.labelminpocet.TabIndex = 15;
            this.labelminpocet.Text = "---";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(213, 334);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(23, 17);
            this.labelmin.TabIndex = 14;
            this.labelmin.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 40);
            this.label8.TabIndex = 17;
            this.label8.Text = "Zadej zde číslo pro vygenerování\r\nnáhodných čísel z intervalu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(224, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 52);
            this.label9.TabIndex = 18;
            this.label9.Text = "1.Úkol";
            // 
            // Ukol1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelminprvni);
            this.Controls.Add(this.labelminpocet);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelmaxposledni);
            this.Controls.Add(this.labelmaxipocet);
            this.Controls.Add(this.labelmax);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prevod);
            this.Name = "Ukol1";
            this.Text = "Ukol1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelmax;
        private System.Windows.Forms.Label labelmaxipocet;
        private System.Windows.Forms.Label labelmaxposledni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelminprvni;
        private System.Windows.Forms.Label labelminpocet;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}