class HelloWorld {
  static void Main() {
   
    int[] sayi = new int[20]; // 20 elemanlı dizi oluşturuldu.
    Random rnd = new Random();
    int enbuyuk=0;
 
   for (int i =0;i<sayi.Length;i++){
       sayi[i]=rnd.Next(100,999);
       if (sayi[i] > enbuyuk)
                {
                    enbuyuk = sayi[i];
                }
        
   }
   
   Array.Sort(sayi);
   Array.Reverse(sayi);
   
   foreach(int eleman in sayi){
       
       Console.WriteLine(eleman);
       
   }
   
   Console.WriteLine("en bhuyuk"+enbuyuk);
   Console.ReadKey();
  }
}
