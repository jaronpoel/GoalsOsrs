namespace Coalitie
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Meerderheid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PartijNaam = new System.Windows.Forms.TextBox();
            this.StemmenPartij = new System.Windows.Forms.NumericUpDown();
            this.MaxZetels = new System.Windows.Forms.NumericUpDown();
            this.VerkiezingsPartijen = new System.Windows.Forms.ListBox();
            this.Coalition = new System.Windows.Forms.ListBox();
            this.Threshold = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StemmenPartij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxZetels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check coalitie voor meederheid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voeg toe aan coalitie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Meerderheid
            // 
            this.Meerderheid.AutoSize = true;
            this.Meerderheid.Location = new System.Drawing.Point(429, 163);
            this.Meerderheid.Name = "Meerderheid";
            this.Meerderheid.Size = new System.Drawing.Size(16, 13);
            this.Meerderheid.TabIndex = 4;
            this.Meerderheid.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Zetels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Partij Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stemmen gekregen";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Voeg partij toe aan verkiezing";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PartijNaam
            // 
            this.PartijNaam.Location = new System.Drawing.Point(115, 12);
            this.PartijNaam.Name = "PartijNaam";
            this.PartijNaam.Size = new System.Drawing.Size(120, 20);
            this.PartijNaam.TabIndex = 9;
            // 
            // StemmenPartij
            // 
            this.StemmenPartij.Location = new System.Drawing.Point(115, 38);
            this.StemmenPartij.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.StemmenPartij.Name = "StemmenPartij";
            this.StemmenPartij.Size = new System.Drawing.Size(120, 20);
            this.StemmenPartij.TabIndex = 10;
            // 
            // MaxZetels
            // 
            this.MaxZetels.Location = new System.Drawing.Point(77, 132);
            this.MaxZetels.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxZetels.Name = "MaxZetels";
            this.MaxZetels.Size = new System.Drawing.Size(120, 20);
            this.MaxZetels.TabIndex = 11;
            this.MaxZetels.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // VerkiezingsPartijen
            // 
            this.VerkiezingsPartijen.FormattingEnabled = true;
            this.VerkiezingsPartijen.Location = new System.Drawing.Point(274, 11);
            this.VerkiezingsPartijen.Name = "VerkiezingsPartijen";
            this.VerkiezingsPartijen.Size = new System.Drawing.Size(149, 134);
            this.VerkiezingsPartijen.TabIndex = 12;
            // 
            // Coalition
            // 
            this.Coalition.FormattingEnabled = true;
            this.Coalition.Location = new System.Drawing.Point(432, 11);
            this.Coalition.Name = "Coalition";
            this.Coalition.Size = new System.Drawing.Size(181, 108);
            this.Coalition.TabIndex = 13;
            // 
            // Threshold
            // 
            this.Threshold.Location = new System.Drawing.Point(77, 156);
            this.Threshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(120, 20);
            this.Threshold.TabIndex = 15;
            this.Threshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kiesdrempel";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Bereken zetels";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 189);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Threshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Coalition);
            this.Controls.Add(this.VerkiezingsPartijen);
            this.Controls.Add(this.MaxZetels);
            this.Controls.Add(this.StemmenPartij);
            this.Controls.Add(this.PartijNaam);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Meerderheid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StemmenPartij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxZetels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Meerderheid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PartijNaam;
        private System.Windows.Forms.NumericUpDown StemmenPartij;
        private System.Windows.Forms.NumericUpDown MaxZetels;
        private System.Windows.Forms.ListBox VerkiezingsPartijen;
        private System.Windows.Forms.ListBox Coalition;
        private System.Windows.Forms.NumericUpDown Threshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}

