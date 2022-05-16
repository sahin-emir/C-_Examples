
namespace form1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdhacim = new System.Windows.Forms.RadioButton();
            this.rdalan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rddikdörgen = new System.Windows.Forms.RadioButton();
            this.rdkare = new System.Windows.Forms.RadioButton();
            this.rddaire = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdhacim);
            this.groupBox1.Controls.Add(this.rdalan);
            this.groupBox1.Location = new System.Drawing.Point(43, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Seçin";
            // 
            // rdhacim
            // 
            this.rdhacim.AutoSize = true;
            this.rdhacim.Location = new System.Drawing.Point(19, 58);
            this.rdhacim.Name = "rdhacim";
            this.rdhacim.Size = new System.Drawing.Size(98, 17);
            this.rdhacim.TabIndex = 1;
            this.rdhacim.Text = "Hacim HEsapla";
            this.rdhacim.UseVisualStyleBackColor = true;
            this.rdhacim.CheckedChanged += new System.EventHandler(this.rdhacim_CheckedChanged);
            // 
            // rdalan
            // 
            this.rdalan.AutoSize = true;
            this.rdalan.Checked = true;
            this.rdalan.Location = new System.Drawing.Point(19, 34);
            this.rdalan.Name = "rdalan";
            this.rdalan.Size = new System.Drawing.Size(88, 17);
            this.rdalan.TabIndex = 0;
            this.rdalan.TabStop = true;
            this.rdalan.Text = "alan HEsapla";
            this.rdalan.UseVisualStyleBackColor = true;
            this.rdalan.CheckedChanged += new System.EventHandler(this.rdalan_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rddikdörgen);
            this.groupBox2.Controls.Add(this.rdkare);
            this.groupBox2.Controls.Add(this.rddaire);
            this.groupBox2.Location = new System.Drawing.Point(330, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şekil Şeçiniz";
            // 
            // rddikdörgen
            // 
            this.rddikdörgen.AutoSize = true;
            this.rddikdörgen.Location = new System.Drawing.Point(31, 80);
            this.rddikdörgen.Name = "rddikdörgen";
            this.rddikdörgen.Size = new System.Drawing.Size(77, 17);
            this.rddikdörgen.TabIndex = 2;
            this.rddikdörgen.Text = "Dikdörtgen";
            this.rddikdörgen.UseVisualStyleBackColor = true;
            this.rddikdörgen.CheckedChanged += new System.EventHandler(this.rddikdörgen_CheckedChanged);
            // 
            // rdkare
            // 
            this.rdkare.AutoSize = true;
            this.rdkare.Location = new System.Drawing.Point(31, 57);
            this.rdkare.Name = "rdkare";
            this.rdkare.Size = new System.Drawing.Size(47, 17);
            this.rdkare.TabIndex = 1;
            this.rdkare.Text = "Kare";
            this.rdkare.UseVisualStyleBackColor = true;
            this.rdkare.CheckedChanged += new System.EventHandler(this.rdkare_CheckedChanged);
            // 
            // rddaire
            // 
            this.rddaire.AutoSize = true;
            this.rddaire.Checked = true;
            this.rddaire.Location = new System.Drawing.Point(31, 34);
            this.rddaire.Name = "rddaire";
            this.rddaire.Size = new System.Drawing.Size(50, 17);
            this.rddaire.TabIndex = 0;
            this.rddaire.TabStop = true;
            this.rddaire.Text = "Daire";
            this.rddaire.UseVisualStyleBackColor = true;
            this.rddaire.CheckedChanged += new System.EventHandler(this.rddaire_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(421, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(353, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdalan;
        private System.Windows.Forms.RadioButton rdhacim;
        private System.Windows.Forms.RadioButton rddaire;
        private System.Windows.Forms.RadioButton rdkare;
        private System.Windows.Forms.RadioButton rddikdörgen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}

