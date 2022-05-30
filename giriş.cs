Sqlbaglantisi vgl = new Sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
           // string sorgu = " where usr=@user AND pwd=@pass";
            SqlCommand com= new SqlCommand("SELECT * FROM kullanicilar where kullanciadi=@t1 AND sifre=@t2",vgl.baglanti());


            //new SqlCommand(vgl, com);

            com.Parameters.AddWithValue("@t1", txtad.Text);
            com.Parameters.AddWithValue("@t2", txtsoyad.Text);



            SqlDataReader  dr = com.ExecuteReader();



            if (dr.Read())
            {


                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }


        }
        
        
        ###
        class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=Z10-35;Initial Catalog=kullanici;Integrated Security=True");
            baglan.Open();
            return baglan;

        }

    }
