
namespace GUI_Premikanje
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
            this.fmf = new System.Windows.Forms.Label();
            this.casovnik = new System.Windows.Forms.Timer(this.components);
            this.label_fmf = new System.Windows.Forms.Label();
            this.label_P3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fmf
            // 
            this.fmf.Location = new System.Drawing.Point(0, 0);
            this.fmf.Name = "fmf";
            this.fmf.Size = new System.Drawing.Size(100, 23);
            this.fmf.TabIndex = 0;
            // 
            // casovnik
            // 
            this.casovnik.Tick += new System.EventHandler(this.casovnik_Tick);
            // 
            // label_fmf
            // 
            this.label_fmf.AutoSize = true;
            this.label_fmf.Location = new System.Drawing.Point(344, 98);
            this.label_fmf.Name = "label_fmf";
            this.label_fmf.Size = new System.Drawing.Size(35, 17);
            this.label_fmf.TabIndex = 1;
            this.label_fmf.Text = "FMF";
            // 
            // label_P3
            // 
            this.label_P3.AutoSize = true;
            this.label_P3.Location = new System.Drawing.Point(344, 247);
            this.label_P3.Name = "label_P3";
            this.label_P3.Size = new System.Drawing.Size(25, 17);
            this.label_P3.TabIndex = 2;
            this.label_P3.Text = "P3";
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
            this.Controls.Add(this.label_P3);
            this.Controls.Add(this.label_fmf);
            this.Controls.Add(this.fmf);
            this.Name = "Form1";
            this.Text = "Prikazovalnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fmf;
        private System.Windows.Forms.Timer casovnik;
        private System.Windows.Forms.Label label_fmf;
        private System.Windows.Forms.Label label_P3;
        private System.Windows.Forms.Timer timer;
    }
}

