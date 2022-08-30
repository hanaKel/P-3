
namespace GUI_Seštevalnik
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
            System.Windows.Forms.Label drugi;
            this.plus = new System.Windows.Forms.Label();
            this.je = new System.Windows.Forms.Label();
            this.vsota = new System.Windows.Forms.Label();
            this.izracunaj = new System.Windows.Forms.Button();
            this.str1 = new System.Windows.Forms.TextBox();
            this.str2 = new System.Windows.Forms.TextBox();
            drugi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.CausesValidation = false;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(199, 118);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(49, 37);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            // 
            // drugi
            // 
            drugi.AutoSize = true;
            drugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            drugi.Location = new System.Drawing.Point(338, 137);
            drugi.Name = "drugi";
            drugi.Size = new System.Drawing.Size(0, 39);
            drugi.TabIndex = 2;
            // 
            // je
            // 
            this.je.AutoSize = true;
            this.je.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.je.Location = new System.Drawing.Point(398, 121);
            this.je.Name = "je";
            this.je.Size = new System.Drawing.Size(37, 39);
            this.je.TabIndex = 3;
            this.je.Text = "=";
            // 
            // vsota
            // 
            this.vsota.BackColor = System.Drawing.SystemColors.Info;
            this.vsota.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vsota.Location = new System.Drawing.Point(455, 112);
            this.vsota.Name = "vsota";
            this.vsota.Size = new System.Drawing.Size(127, 56);
            this.vsota.TabIndex = 4;
            this.vsota.Text = "0";
            this.vsota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // izracunaj
            // 
            this.izracunaj.AllowDrop = true;
            this.izracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izracunaj.Location = new System.Drawing.Point(172, 222);
            this.izracunaj.Name = "izracunaj";
            this.izracunaj.Size = new System.Drawing.Size(135, 48);
            this.izracunaj.TabIndex = 6;
            this.izracunaj.Text = "IZRACUNAJ";
            this.izracunaj.UseVisualStyleBackColor = true;
            this.izracunaj.Click += new System.EventHandler(this.izracunaj_Click);
            // 
            // str1
            // 
            this.str1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.str1.Location = new System.Drawing.Point(93, 118);
            this.str1.Name = "str1";
            this.str1.Size = new System.Drawing.Size(100, 45);
            this.str1.TabIndex = 7;
            this.str1.Text = "0";
            this.str1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // str2
            // 
            this.str2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.str2.Location = new System.Drawing.Point(268, 118);
            this.str2.Name = "str2";
            this.str2.Size = new System.Drawing.Size(100, 45);
            this.str2.TabIndex = 8;
            this.str2.Text = "0";
            this.str2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.str2);
            this.Controls.Add(this.str1);
            this.Controls.Add(this.izracunaj);
            this.Controls.Add(this.vsota);
            this.Controls.Add(this.je);
            this.Controls.Add(drugi);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "SEŠTEVLANIK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label je;
        private System.Windows.Forms.Label vsota;
        private System.Windows.Forms.Button izracunaj;
        private System.Windows.Forms.TextBox str1;
        private System.Windows.Forms.TextBox str2;
    }
}

