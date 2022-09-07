
namespace Nobel
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
            this.izpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.izberiLetoOd = new System.Windows.Forms.ComboBox();
            this.izberiLetoDo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // izpis
            // 
            this.izpis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.izpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.izpis.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izpis.Location = new System.Drawing.Point(553, 27);
            this.izpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izpis.Multiline = true;
            this.izpis.Name = "izpis";
            this.izpis.ReadOnly = true;
            this.izpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.izpis.Size = new System.Drawing.Size(485, 482);
            this.izpis.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izberi leto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.CheckOnClick = true;
            this.lista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lista.ForeColor = System.Drawing.SystemColors.Window;
            this.lista.FormattingEnabled = true;
            this.lista.Items.AddRange(new object[] {
            "Kemija",
            "Ekonomija",
            "Literatura",
            "Medicina",
            "Mir",
            "Fizika"});
            this.lista.Location = new System.Drawing.Point(424, 182);
            this.lista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(213, 175);
            this.lista.TabIndex = 5;
            this.lista.ThreeDCheckBoxes = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(110, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRIKAZI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(420, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Področje: ";
            // 
            // izberiLetoOd
            // 
            this.izberiLetoOd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.izberiLetoOd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izberiLetoOd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izberiLetoOd.FormattingEnabled = true;
            this.izberiLetoOd.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.izberiLetoOd.Location = new System.Drawing.Point(132, 53);
            this.izberiLetoOd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izberiLetoOd.Name = "izberiLetoOd";
            this.izberiLetoOd.Size = new System.Drawing.Size(84, 31);
            this.izberiLetoOd.TabIndex = 9;
            // 
            // izberiLetoDo
            // 
            this.izberiLetoDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.izberiLetoDo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.izberiLetoDo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izberiLetoDo.FormattingEnabled = true;
            this.izberiLetoDo.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.izberiLetoDo.Location = new System.Drawing.Point(224, 53);
            this.izberiLetoDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izberiLetoDo.Name = "izberiLetoDo";
            this.izberiLetoDo.Size = new System.Drawing.Size(93, 31);
            this.izberiLetoDo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(123, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 51);
            this.label4.TabIndex = 2;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.izpis);
            this.Controls.Add(this.izberiLetoDo);
            this.Controls.Add(this.izberiLetoOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Nobelovi nagrajencI do leta 2015";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox izpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox izberiLetoOd;
        private System.Windows.Forms.ComboBox izberiLetoDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

