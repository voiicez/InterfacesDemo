namespace InterfacesDemo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTaban = new System.Windows.Forms.TextBox();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYaricap = new System.Windows.Forms.TextBox();
            this.bKoseliHesapla = new System.Windows.Forms.Button();
            this.bKosesizHesapla = new System.Windows.Forms.Button();
            this.comb1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yükseklik";
            // 
            // tbTaban
            // 
            this.tbTaban.Location = new System.Drawing.Point(71, 16);
            this.tbTaban.Name = "tbTaban";
            this.tbTaban.Size = new System.Drawing.Size(100, 23);
            this.tbTaban.TabIndex = 2;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(71, 61);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(100, 23);
            this.tbYukseklik.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbYukseklik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTaban);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Köşeli";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbYaricap);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Köşesiz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yarıçap";
            // 
            // tbYaricap
            // 
            this.tbYaricap.Location = new System.Drawing.Point(71, 16);
            this.tbYaricap.Name = "tbYaricap";
            this.tbYaricap.Size = new System.Drawing.Size(100, 23);
            this.tbYaricap.TabIndex = 2;
            // 
            // bKoseliHesapla
            // 
            this.bKoseliHesapla.Location = new System.Drawing.Point(218, 46);
            this.bKoseliHesapla.Name = "bKoseliHesapla";
            this.bKoseliHesapla.Size = new System.Drawing.Size(75, 23);
            this.bKoseliHesapla.TabIndex = 4;
            this.bKoseliHesapla.Text = "hesapla";
            this.bKoseliHesapla.UseVisualStyleBackColor = true;
            this.bKoseliHesapla.Click += new System.EventHandler(this.bKoseliHesapla_Click);
            // 
            // bKosesizHesapla
            // 
            this.bKosesizHesapla.Location = new System.Drawing.Point(218, 184);
            this.bKosesizHesapla.Name = "bKosesizHesapla";
            this.bKosesizHesapla.Size = new System.Drawing.Size(75, 23);
            this.bKosesizHesapla.TabIndex = 4;
            this.bKosesizHesapla.Text = "hesapla";
            this.bKosesizHesapla.UseVisualStyleBackColor = true;
            this.bKosesizHesapla.Click += new System.EventHandler(this.bKosesizHesapla_Click);
            // 
            // comb1
            // 
            this.comb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb1.FormattingEnabled = true;
            this.comb1.Location = new System.Drawing.Point(218, 17);
            this.comb1.Name = "comb1";
            this.comb1.Size = new System.Drawing.Size(66, 23);
            this.comb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comb1);
            this.Controls.Add(this.bKosesizHesapla);
            this.Controls.Add(this.bKoseliHesapla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox tbTaban;
        private TextBox tbYukseklik;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox tbYaricap;
        private Button bKoseliHesapla;
        private Button bKosesizHesapla;
        private ComboBox comb1;
    }
}