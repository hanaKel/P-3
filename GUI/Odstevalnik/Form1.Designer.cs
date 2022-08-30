
namespace GUI_Odstevalnik
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
            this.components = new System.ComponentModel.Container();
            this.odtsevalnik = new System.Windows.Forms.Label();
            this.gumb_ponastavi = new System.Windows.Forms.Button();
            this.gumb_ustavi = new System.Windows.Forms.Button();
            this.gumb_zacni = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // odtsevalnik
            // 
            this.odtsevalnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odtsevalnik.Location = new System.Drawing.Point(284, 57);
            this.odtsevalnik.Name = "odtsevalnik";
            this.odtsevalnik.Size = new System.Drawing.Size(178, 175);
            this.odtsevalnik.TabIndex = 0;
            this.odtsevalnik.Text = "9";
            this.odtsevalnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.odtsevalnik.Click += new System.EventHandler(this.odtsevalnik_Click);
            // 
            // gumb_ponastavi
            // 
            this.gumb_ponastavi.Location = new System.Drawing.Point(566, 323);
            this.gumb_ponastavi.Name = "gumb_ponastavi";
            this.gumb_ponastavi.Size = new System.Drawing.Size(137, 61);
            this.gumb_ponastavi.TabIndex = 1;
            this.gumb_ponastavi.Text = "PONASTAVI";
            this.gumb_ponastavi.UseVisualStyleBackColor = true;
            this.gumb_ponastavi.Click += new System.EventHandler(this.gumb_ponastavi_Click);
            // 
            // gumb_ustavi
            // 
            this.gumb_ustavi.Location = new System.Drawing.Point(291, 323);
            this.gumb_ustavi.Name = "gumb_ustavi";
            this.gumb_ustavi.Size = new System.Drawing.Size(137, 61);
            this.gumb_ustavi.TabIndex = 2;
            this.gumb_ustavi.Text = "USTAVI";
            this.gumb_ustavi.UseVisualStyleBackColor = true;
            this.gumb_ustavi.Click += new System.EventHandler(this.gumb_ustavi_Click);
            // 
            // gumb_zacni
            // 
            this.gumb_zacni.Location = new System.Drawing.Point(56, 323);
            this.gumb_zacni.Name = "gumb_zacni";
            this.gumb_zacni.Size = new System.Drawing.Size(137, 61);
            this.gumb_zacni.TabIndex = 3;
            this.gumb_zacni.Text = "ZACNI";
            this.gumb_zacni.UseVisualStyleBackColor = true;
            this.gumb_zacni.Click += new System.EventHandler(this.gumb_zacni_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumb_zacni);
            this.Controls.Add(this.gumb_ustavi);
            this.Controls.Add(this.gumb_ponastavi);
            this.Controls.Add(this.odtsevalnik);
            this.Name = "Form1";
            this.Text = "Odštevalnik";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label odtsevalnik;
        private System.Windows.Forms.Button gumb_ponastavi;
        private System.Windows.Forms.Button gumb_ustavi;
        private System.Windows.Forms.Button gumb_zacni;
        private System.Windows.Forms.Timer timer;
    }
}

