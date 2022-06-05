// combobox veri karşılaştırma


comboBox1.Items.Add(textBox1.Text);

if (comboBox1.Items.IndexOf(textBox1.Text) != -1) {

//MessageBox.Show("Kayıtlı Bilgi Vardır.");
    DialogResult secenek= MessageBox.Show("İşlem yapılsın mı?", "Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
 
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


