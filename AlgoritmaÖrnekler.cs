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
    
    Console.WriteLine(" 1/ kare ALanı 2/ Kare çevresi 3/çıkış");
    int secim=Convert.ToInt32(Console.ReadLine());
    
    int kenar;
    switch(secim){
        
        case 1:
            Console.WriteLine("karenini kenarını giriniz");
            kenar=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Karenin alanı"+kenar*kenar);
            break;
        case 2:
            Console.WriteLine("karenin bir kenarını giriniz");
            kenar=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kareçevre"+4*kenar);
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("hatalıişlem");
            break;
    }
    
    Console.ReadLine();
    
    
