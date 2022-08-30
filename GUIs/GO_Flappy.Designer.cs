
namespace FlappyBird
{
    partial class GO_Flappy
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
            this.ptic = new System.Windows.Forms.PictureBox();
            this.tla = new System.Windows.Forms.PictureBox();
            this.oviraGor = new System.Windows.Forms.PictureBox();
            this.oviraDol = new System.Windows.Forms.PictureBox();
            this.timerIgra = new System.Windows.Forms.Timer(this.components);
            this.konec = new System.Windows.Forms.Label();
            this.zacni = new System.Windows.Forms.Button();
            this.label_tocke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraGor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraDol)).BeginInit();
            this.SuspendLayout();
            // 
            // ptic
            // 
            this.ptic.Image = global::FlappyBird.Properties.Resources.Ptic;
            this.ptic.Location = new System.Drawing.Point(156, 226);
            this.ptic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptic.Name = "ptic";
            this.ptic.Size = new System.Drawing.Size(69, 40);
            this.ptic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptic.TabIndex = 0;
            this.ptic.TabStop = false;
            // 
            // tla
            // 
            this.tla.Image = global::FlappyBird.Properties.Resources.tla;
            this.tla.Location = new System.Drawing.Point(-4, 530);
            this.tla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tla.Name = "tla";
            this.tla.Size = new System.Drawing.Size(1072, 67);
            this.tla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tla.TabIndex = 0;
            this.tla.TabStop = false;
            // 
            // oviraGor
            // 
            this.oviraGor.Image = global::FlappyBird.Properties.Resources.OviraGor;
            this.oviraGor.Location = new System.Drawing.Point(825, 339);
            this.oviraGor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oviraGor.Name = "oviraGor";
            this.oviraGor.Size = new System.Drawing.Size(89, 278);
            this.oviraGor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oviraGor.TabIndex = 1;
            this.oviraGor.TabStop = false;
            // 
            // oviraDol
            // 
            this.oviraDol.Image = global::FlappyBird.Properties.Resources.OviraDol;
            this.oviraDol.Location = new System.Drawing.Point(534, -39);
            this.oviraDol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oviraDol.Name = "oviraDol";
            this.oviraDol.Size = new System.Drawing.Size(89, 221);
            this.oviraDol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oviraDol.TabIndex = 1;
            this.oviraDol.TabStop = false;
            // 
            // timerIgra
            // 
            this.timerIgra.Interval = 20;
            this.timerIgra.Tick += new System.EventHandler(this.timerIgra_Tick);
            // 
            // konec
            // 
            this.konec.AutoSize = true;
            this.konec.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konec.Location = new System.Drawing.Point(327, 235);
            this.konec.Name = "konec";
            this.konec.Size = new System.Drawing.Size(0, 91);
            this.konec.TabIndex = 2;
            // 
            // zacni
            // 
            this.zacni.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zacni.Location = new System.Drawing.Point(402, 260);
            this.zacni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zacni.Name = "zacni";
            this.zacni.Size = new System.Drawing.Size(196, 85);
            this.zacni.TabIndex = 3;
            this.zacni.Text = "ZAČNI";
            this.zacni.UseVisualStyleBackColor = true;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // label_tocke
            // 
            this.label_tocke.Location = new System.Drawing.Point(2, 9);
            this.label_tocke.Name = "label_tocke";
            this.label_tocke.Size = new System.Drawing.Size(127, 50);
            this.label_tocke.TabIndex = 4;
            this.label_tocke.Click += new System.EventHandler(this.label_tocke_Click);
            // 
            // GO_Flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1047, 595);
            this.Controls.Add(this.label_tocke);
            this.Controls.Add(this.zacni);
            this.Controls.Add(this.konec);
            this.Controls.Add(this.tla);
            this.Controls.Add(this.oviraDol);
            this.Controls.Add(this.oviraGor);
            this.Controls.Add(this.ptic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GO_Flappy";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipkaDol);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tipkaGor);
            ((System.ComponentModel.ISupportInitialize)(this.ptic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraGor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraDol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptic;
        private System.Windows.Forms.PictureBox tla;
        private System.Windows.Forms.PictureBox oviraGor;
        private System.Windows.Forms.PictureBox oviraDol;
        private System.Windows.Forms.Timer timerIgra;
        private System.Windows.Forms.Label konec;
        private System.Windows.Forms.Button zacni;
        private System.Windows.Forms.Label label_tocke;
    }
}

