    // Vize final not hesaplama
    
    double vizenot,finalnot,ort;
    Console.WriteLine("Vize Final Nolarını giriniz");
    vizenot=Convert.ToDouble(Console.ReadLine());
    finalnot=Convert.ToDouble(Console.ReadLine());
    
    ort=vizenot*0.4 + finalnot*0.6;
    Console.WriteLine("ortalama"+ort);
    Console.ReadLine();
    
    
    int sayi,enbuyuk;
    Console.WriteLine("Sayi giriniz");
    sayi=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("SAyının karekökü"+sayi*sayi);
    Console.WriteLine("SAyının karekökü"+ Math.Pow(sayi,3));
    Console.WriteLine("Sayınn karakökü "+Math.Sqrt(sayi));//karaköküne yuvarlar
    double sinus=Math.Sin(sayi);
    enbuyuk=Math.Max(8,10);
    Console.WriteLine("sayı büyük"+enbuyuk +"sinus "+ sinus);
    
    
    
    
