// combobox veri karşılaştırma
comboBox1.Items.Add(textBox1.Text);
if (comboBox1.Items.IndexOf(textBox1.Text) != -1) {
//MessageBox.Show("Kayıtlı Bilgi Vardır.");
    DialogResult secenek= MessageBox.Show("Aynı ogeden var ?", "Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
 
              if (secenek == DialogResult.Yes)
              {
                  MessageBox.Show("Ekleme yapabilirsiniz.");
              }
              else if(secenek==DialogResult.No)
              {
                 this.Close();
                  Application.Exit();
              }
 }
else
comboBox1.Items.Add(textBox1.Text);
/////////////// faktoriyel form
int sayi, sonuc = 1;
            sayi = Convert.ToInt32(txtSayi.Text);
            for(int i=1;i<=sayi;i++)
            {
                sonuc *= i;
            }
            lblSonuc.Text = sonuc.ToString();
////////////////7///////////////////////////////////////////////////
//// hesap makinesi;
//Button kodlari
if(textbox1.text="0"){
    {
    textbox1.Text="";
    }
textbox1.Text=textbox1.Text+(Button)sender).Text;
// virgul kodlari
if(textbox1.Text.IndexOf(",")<1)
    {
        textbox1.Text=textbox1.Text+",";

    }
// C silme kodu
    textbox1.Text="0";
 // tek tek silme
    textbox1.Text=textbox1.Text.Substring(0,textbox1.Text.Length-1)
    if(textbox1.Text="")
    {
        textbox1.Text="0";
    }
// toplama çoıkarma btnleri
    sayi1=doubleParse(textbox1.Text);
    textbox1.Text="0";
    secim=1;
    int secim=0;
    
   // Eşitttir kodu
    sayi2=doubleParse(textbox1.Text);   
    if(secim==1){
        sonuc=sayi1+sayi2;
        textbox1.Text=sonuc.ToString()
       }
///////////////////////////////////////////////////////////////77
    
    
    /////Veri Tabanı /////////77
    
    Class veri tabanı
    using System.Data.SqlClient;

    public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=Z10-00;Initial Catalog=uygulama;
            Integrated Security=True");
            baglan.Open();
            return baglan;

        }
                ///form codes
                Sqlbaglantisi bgl = new Sqlbaglantisi();
                    // btn kod secme oturum açma işlemi 
                    SqlCommand komut = new SqlCommand("select * from kullanicilar where kullaniciadi=@p1 and sifre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", textBox1.Text);
                    komut.Parameters.AddWithValue("@p2", textBox2.Text);

                        SqlDataReader dr = komut.ExecuteReader();

                        if (dr.Read())
                        {
                            Form2 frm = new Form2();
                            
                            frm.kullaniciadi = textBox1.Text;frm.Show();
                            this.Hide();

                        }
                        else
                            MessageBox.Show("Hatalı giriş");

                    }
                    // Listeleme
                            Sqlbaglantisi bgl = new Sqlbaglantisi();
                            // private void Form2_Load(object sender, EventArgs e)
                            // {
                            //     dataGridView1.Visible = false;
                            //     label1.Text = kullaniciadi;
                            // }
                            SqlCommand komut = new SqlCommand("select * from kullanicilar", bgl.baglanti());
                            SqlDataAdapter da = new SqlDataAdapter(komut);

                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                    // ekleme
                            SqlCommand komut = new SqlCommand("insert into kullanicilar (ogrencino,kullaniciadi,sifre) values (@p1,@p2,@p3)", bgl.baglanti());

                            // komut.Parameters.AddWithValue("@p1", textBox1.Text);
                            // komut.Parameters.AddWithValue("@p2", textBox2.Text);
                            // komut.Parameters.AddWithValue("@p3", textBox3.Text);
                            // komut.ExecuteNonQuery();
                            // MessageBox.Show("Kayıt tamamlandı");
                    // güncelleme
                            // SqlCommand komut = new SqlCommand("update kullanicilar set kullaniciadi=@p1,sifre=@p2 where ogrencino=@p3", bgl.baglanti());
                            // komut.Parameters.AddWithValue("@p1", textBox1.Text);
                            // komut.Parameters.AddWithValue("@p2", textBox2.Text);
                            // komut.Parameters.AddWithValue("@p3", textBox3.Text);
                            // komut.ExecuteNonQuery();
                            // MessageBox.Show("güncelleme yapıldı");
                    // silme
                            // SqlCommand komut = new SqlCommand("delete from kullanicilar where ogrencino=@p1", bgl.baglanti());
                            // komut.Parameters.AddWithValue("@p1", textBox1.Text);

                            // komut.ExecuteNonQuery();
                    // datagridview işlemei
                            // int secilen = dataGridView1.SelectedCells[0].RowIndex;
                            //     textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                            //     textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                            // textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
////////////////////77    //////  ///   ////    U/ U//////

    
    
    
    // String metodları
 // Empty
    string a = "Ahmet";
    string b = "Cansever";
    string metin1="aaaaaa";
    string metin2="bb";
    b = string.Empty;// boşaltır
    
    Console.WriteLine(String.Concat(a, b));
    
    // Concat
    string birlestirilen = String.Concat(metin1, metin2);
 
    Console.WriteLine("kelimelerinin birleştirilmiş hali: "+birlestirilen);
    // compare
    int donusDegeri = String.Compare(metin1, metin2);
    Console.WriteLine(donusDegeri);
    
    // split
    string[] dizi=metin1.Split(' ');
    foreach(string item in dizi){
        Console.WriteLine(item);
    }
    
    Console.ReadKey();



