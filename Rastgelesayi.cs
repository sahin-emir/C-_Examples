/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld {
  static void Main() {
   
    int[] sayi = new int[20]; // 20 elemanlı dizi oluşturuldu.
    Random rnd = new Random();
    int enbuyuk=0;
    int ort=0;
    int toplam=0;
    
 
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
   // Ortalama
   foreach(int ortat in sayi){
       toplam+=ortat;
       ort=toplam/20;
   }
   Console.WriteLine("ortlalamnız"+ort);
   
   Console.WriteLine("en bhuyuk"+enbuyuk);
   Console.ReadKey();
  }
}
