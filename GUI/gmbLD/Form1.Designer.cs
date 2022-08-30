
namespace GUI_LD
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
            this.levi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.besedilo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // levi
            // 
            this.levi.Location = new System.Drawing.Point(83, 220);
            this.levi.Name = "levi";
            this.levi.Size = new System.Drawing.Size(75, 23);
            this.levi.TabIndex = 0;
            this.levi.Text = "Levi";
            this.levi.UseVisualStyleBackColor = true;
            this.levi.Click += new System.EventHandler(this.levi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // besedilo
            // 
            this.besedilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.besedilo.Location = new System.Drawing.Point(219, 205);
            this.besedilo.Name = "besedilo";
            this.besedilo.Size = new System.Drawing.Size(317, 65);
            this.besedilo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.besedilo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.levi);
            this.Name = "Form1";
            this.Text = "Levi in desni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button levi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label besedilo;
    }
}

