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



