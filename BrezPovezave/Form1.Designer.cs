
namespace BrezPovezave
{
    partial class filmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmi));
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_naslov = new System.Windows.Forms.TextBox();
            this.izpis_podatkov = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ocena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_leto = new System.Windows.Forms.TextBox();
            this.brisalniTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.izpis_podatkov)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.Red;
            this.buttonDodaj.Location = new System.Drawing.Point(132, 414);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(117, 36);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "VNESI !";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(94, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vnesi v bazo podatkov nov film";
            // 
            // txt_naslov
            // 
            this.txt_naslov.Location = new System.Drawing.Point(109, 272);
            this.txt_naslov.Multiline = true;
            this.txt_naslov.Name = "txt_naslov";
            this.txt_naslov.Size = new System.Drawing.Size(296, 48);
            this.txt_naslov.TabIndex = 2;
            // 
            // izpis_podatkov
            // 
            this.izpis_podatkov.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.izpis_podatkov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izpis_podatkov.Location = new System.Drawing.Point(442, 12);
            this.izpis_podatkov.Name = "izpis_podatkov";
            this.izpis_podatkov.RowHeadersWidth = 51;
            this.izpis_podatkov.RowTemplate.Height = 24;
            this.izpis_podatkov.Size = new System.Drawing.Size(431, 454);
            this.izpis_podatkov.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ocena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(33, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naslov";
            // 
            // txt_ocena
            // 
            this.txt_ocena.Location = new System.Drawing.Point(104, 344);
            this.txt_ocena.Multiline = true;
            this.txt_ocena.Name = "txt_ocena";
            this.txt_ocena.Size = new System.Drawing.Size(117, 51);
            this.txt_ocena.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 245);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(249, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Leto";
            // 
            // txt_leto
            // 
            this.txt_leto.Location = new System.Drawing.Point(305, 344);
            this.txt_leto.Multiline = true;
            this.txt_leto.Name = "txt_leto";
            this.txt_leto.Size = new System.Drawing.Size(100, 51);
            this.txt_leto.TabIndex = 9;
            // 
            // brisalniTimer
            // 
            this.brisalniTimer.Interval = 500;
            this.brisalniTimer.Tick += new System.EventHandler(this.brisalniTimer_Tick);
            // 
            // filmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.txt_leto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ocena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.izpis_podatkov);
            this.Controls.Add(this.txt_naslov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "filmi";
            this.Text = "FILMI";
            ((System.ComponentModel.ISupportInitialize)(this.izpis_podatkov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_naslov;
        private System.Windows.Forms.DataGridView izpis_podatkov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ocena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_leto;
        private System.Windows.Forms.Timer brisalniTimer;
    }
}

