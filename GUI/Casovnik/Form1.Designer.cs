
namespace GUI_časovnik
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
            this.StartStop = new System.Windows.Forms.Button();
            this.casovnik = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartStop
            // 
            this.StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartStop.Location = new System.Drawing.Point(324, 352);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(154, 44);
            this.StartStop.TabIndex = 0;
            this.StartStop.Text = "StartStop";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // casovnik
            // 
            this.casovnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.casovnik.Location = new System.Drawing.Point(315, 49);
            this.casovnik.Name = "casovnik";
            this.casovnik.Size = new System.Drawing.Size(154, 150);
            this.casovnik.TabIndex = 1;
            this.casovnik.Text = "0";
            this.casovnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.casovnik);
            this.Controls.Add(this.StartStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label casovnik;
        private System.Windows.Forms.Timer timer;
    }
}

