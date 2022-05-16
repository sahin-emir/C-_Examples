using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = 3.14;

            if (rdalan.Checked == true)
            {
                if (rddaire.Checked == true)
                {
                    double yarıçap = Convert.ToDouble(textBox1.Text);



                    double dairealan = pi * yarıçap * yarıçap;
                    textBox4.Text = dairealan.ToString();
                }

                if (rdkare.Checked == true)
                {
                    int kenar = Convert.ToInt32(textBox2.Text);

                    double sonuc = kenar * kenar;
                    textBox4.Text = sonuc.ToString();
                }
                if (rddikdörgen.Checked == true)
                {
                    int dikdörrtgenalan;
                    int kısakenar = Convert.ToInt32(textBox2.Text);
                    int uzunkenar = Convert.ToInt32(textBox3.Text);

                    int alan = kısakenar * uzunkenar;
                    textBox4.Text = alan.ToString();
                    
                }

            }
            else if (rdhacim.Checked == true)
            {
                if (rddaire.Checked == true)
                {
                    double hacim;
                    double yarıçap = Convert.ToDouble(textBox1.Text);
                    hacim = (4 * Math.PI * Math.Pow(yarıçap, 3)/3);
                    textBox4.Text = Convert.ToString (hacim);



                }
                if (rdkare.Checked == true)
                {
                    int kenar;
                    kenar = Convert.ToInt32(textBox2.Text);
                    double hacim = (kenar * kenar * kenar);
                    textBox4.Text = hacim.ToString();
                }
                if (rddikdörgen.Checked == true)
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox2.Text);
                    int c = Convert.ToInt32(textBox3.Text);
                    int hacim = a * b * c;
                    textBox4.Text = hacim.ToString();

                }
            }

        }


        private void rdalan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdalan.Checked)
            {
                rddaire.Text = "Daire";
                rddikdörgen.Text = "Dikdörtgen";
                rdkare.Text = "KAre";
                textBox3.Visible = false;
                label5.Text = "Alan";
                textBox2.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label2.Visible = true;
                label2.Text = "yarıçap";
                textBox1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rddaire_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = "Yarıçap";
            textBox1.Visible = true;


            label4.Visible = false;
            textBox2.Visible = false;

            label6.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
            if (rddaire.Text == "küre")
            {
                label2.Text = "Yarıçap";
                textBox1.Visible = true;

                label4.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label6.Visible = false;
            }

        }

        private void rdhacim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdhacim.Checked)
            {
                textBox2.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
                label1.Visible = false;
                textBox3.Visible = false;
                rddaire.Text = "küre";
                rdkare.Text = "Küp";
                rddikdörgen.Text = "Dikdörgen prizma";
                label5.Text = "Hacim";
                label1.Text = "Yükseklijk";
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label6.Visible = true;
                label6.Text = "Yükseklik";
                textBox3.Visible = true;


            }
        }

        private void rdkare_CheckedChanged(object sender, EventArgs e)
        {
            
            textBox1.Visible = false;
            label2.Visible = false;

            label4.Visible = true;
            label4.Text = "Kenar uzunluğu";
            textBox2.Visible = true;
            if(rdkare.Text== "Küp")
            {
                label4.Text = "Kenar uzunluğu";
                textBox2.Visible = true;
                textBox3.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
            }

        }

        private void rddikdörgen_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox1.Visible = false;

            textBox2.Visible = true;
            label4.Text = "Kenar";

            label6.Visible = true;
            label6.Text = "YÜkseklik";

            textBox2.Visible = true;
            textBox3.Visible = true;

            if(rddikdörgen.Text=="Dikdörgen prizma")
            {
                label2.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label2.Text = "Taban uzunlunğu";
                label4.Text = "Taban Genişliği";
                label6.Text = "Yükseklik";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;

            }
        }

    }
}
