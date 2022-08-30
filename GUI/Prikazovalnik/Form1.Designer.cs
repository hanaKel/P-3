
namespace GUI_Pikazovalnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slika = new System.Windows.Forms.PictureBox();
            this.Prikazi = new System.Windows.Forms.Button();
            this.timer_SkrjSliko = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // slika
            // 
            this.slika.Image = ((System.Drawing.Image)(resources.GetObject("slika.Image")));
            this.slika.Location = new System.Drawing.Point(12, 12);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(579, 426);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika.TabIndex = 0;
            this.slika.TabStop = false;
            this.slika.Visible = false;
            this.slika.Click += new System.EventHandler(this.slika_Click);
            // 
            // Prikazi
            // 
            this.Prikazi.Location = new System.Drawing.Point(646, 166);
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.Size = new System.Drawing.Size(119, 69);
            this.Prikazi.TabIndex = 1;
            this.Prikazi.Text = "PRIKAZI";
            this.Prikazi.UseVisualStyleBackColor = true;
            this.Prikazi.Click += new System.EventHandler(this.prikaziSliko);
            // 
            // timer_SkrjSliko
            // 
            this.timer_SkrjSliko.Interval = 2000;
            this.timer_SkrjSliko.Tick += new System.EventHandler(this.skrijSliko);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prikazi);
            this.Controls.Add(this.slika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.Button Prikazi;
        private System.Windows.Forms.Timer timer_SkrjSliko;
    }
}

