using System;
class HelloWorld {
  static void Main() {
    
    Random rnd=new Random();
    int pozitif=0;
    int [] sayilar =new int[20];
        
        for (int i =0;i<20;i++){
            sayilar[i]=rnd.Next(-100,100);
        }
        
        foreach(int sayi in sayilar){
            
            Console.WriteLine(sayi);
            if(sayi>0){
                pozitif ++;
            }
           
        }
  }
}
while (true)
            {
                int dogrucevap = rnd.Next(1, 10);
                Console.WriteLine("Sayı tahmin et 1- 10 arası");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == dogrucevap)
                {
                    Console.WriteLine("dogru bildiniz");
                    break;
                }
                else if (sayi < dogrucevap )
                {
                    Console.WriteLine("sayıyı büyült");

                }
                else if (sayi > dogrucevap)
                {
                    Console.WriteLine("sayıyı küçült");

                }
                else
                {
                    Console.WriteLine("1- 10 arası grinbiz");
                }
            }
