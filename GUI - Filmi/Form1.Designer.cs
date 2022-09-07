
namespace Filmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prikaz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leto_do = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ocena_do = new System.Windows.Forms.TextBox();
            this.ocena_od = new System.Windows.Forms.TextBox();
            this.leto_od = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.naslov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.izvedi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // prikaz
            // 
            this.prikaz.BackColor = System.Drawing.SystemColors.HighlightText;
            this.prikaz.ForeColor = System.Drawing.SystemColors.InfoText;
            this.prikaz.Location = new System.Drawing.Point(555, 39);
            this.prikaz.Margin = new System.Windows.Forms.Padding(4);
            this.prikaz.Multiline = true;
            this.prikaz.Name = "prikaz";
            this.prikaz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prikaz.Size = new System.Drawing.Size(609, 479);
            this.prikaz.TabIndex = 1;
            this.prikaz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(75, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leto:";
            // 
            // leto_do
            // 
            this.leto_do.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leto_do.Location = new System.Drawing.Point(287, 226);
            this.leto_do.Margin = new System.Windows.Forms.Padding(4);
            this.leto_do.MaxLength = 4;
            this.leto_do.Multiline = true;
            this.leto_do.Name = "leto_do";
            this.leto_do.Size = new System.Drawing.Size(108, 41);
            this.leto_do.TabIndex = 5;
            this.leto_do.Text = "Do";
            this.leto_do.Click += new System.EventHandler(this.izbrisiTekst2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(53, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ocena:";
            // 
            // ocena_do
            // 
            this.ocena_do.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocena_do.Location = new System.Drawing.Point(287, 275);
            this.ocena_do.Margin = new System.Windows.Forms.Padding(4);
            this.ocena_do.MaxLength = 2;
            this.ocena_do.Multiline = true;
            this.ocena_do.Name = "ocena_do";
            this.ocena_do.Size = new System.Drawing.Size(108, 41);
            this.ocena_do.TabIndex = 8;
            this.ocena_do.Text = "Do";
            this.ocena_do.Click += new System.EventHandler(this.izbrisiTekst4);
            // 
            // ocena_od
            // 
            this.ocena_od.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocena_od.Location = new System.Drawing.Point(170, 275);
            this.ocena_od.Margin = new System.Windows.Forms.Padding(4);
            this.ocena_od.MaxLength = 2;
            this.ocena_od.Multiline = true;
            this.ocena_od.Name = "ocena_od";
            this.ocena_od.Size = new System.Drawing.Size(107, 41);
            this.ocena_od.TabIndex = 9;
            this.ocena_od.Text = "Od";
            this.ocena_od.Click += new System.EventHandler(this.izbrisiTekst3);
            // 
            // leto_od
            // 
            this.leto_od.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leto_od.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leto_od.Location = new System.Drawing.Point(170, 226);
            this.leto_od.Margin = new System.Windows.Forms.Padding(4);
            this.leto_od.MaxLength = 4;
            this.leto_od.Multiline = true;
            this.leto_od.Name = "leto_od";
            this.leto_od.Size = new System.Drawing.Size(109, 41);
            this.leto_od.TabIndex = 10;
            this.leto_od.Text = "Od";
            this.leto_od.Click += new System.EventHandler(this.izbrisiTekst);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(42, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naslov:";
            // 
            // naslov
            // 
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(170, 168);
            this.naslov.Margin = new System.Windows.Forms.Padding(4);
            this.naslov.Multiline = true;
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(360, 41);
            this.naslov.TabIndex = 12;
            this.naslov.Click += new System.EventHandler(this.klikNaslov);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(42, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 34);
            this.label6.TabIndex = 16;
            this.label6.Text = "Režiser:";
            // 
            // izvedi
            // 
            this.izvedi.BackColor = System.Drawing.Color.Silver;
            this.izvedi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izvedi.Location = new System.Drawing.Point(232, 417);
            this.izvedi.Margin = new System.Windows.Forms.Padding(4);
            this.izvedi.Name = "izvedi";
            this.izvedi.Size = new System.Drawing.Size(113, 51);
            this.izvedi.TabIndex = 18;
            this.izvedi.Text = "IŠČI!";
            this.izvedi.UseVisualStyleBackColor = false;
            this.izvedi.Click += new System.EventHandler(this.izvedi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 324);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 42);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Click += new System.EventHandler(this.klikReziser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1177, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.izvedi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leto_od);
            this.Controls.Add(this.ocena_od);
            this.Controls.Add(this.ocena_do);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leto_do);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prikaz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Filmi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prikaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leto_do;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ocena_do;
        private System.Windows.Forms.TextBox ocena_od;
        private System.Windows.Forms.TextBox leto_od;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox naslov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button izvedi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

