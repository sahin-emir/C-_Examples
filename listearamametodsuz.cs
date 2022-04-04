string[] isimler = new string[5];//Bineary-Search metodusuz çözümü 
            string anahtar;

            

            isimler[0] = "Ahmet";
            isimler[1] = "Alş";
            isimler[2] = "Furkan";
            isimler.SetValue( "Halil" ,3 );
            isimler.SetValue ( "Kadir",4 );
            Array.Sort(isimler);


            Console.WriteLine("aranacak kelime giriniz");
            anahtar = Console.ReadLine();
            
            int i=-1;
            while (true)
            {
                i++;
                if(isimler[i] == anahtar){
                    Console.WriteLine("aradaıgınız karakter vardır index no :"+i);
                    break;
                }
                else{
                    Console.WriteLine("aradıgını değer yoktur ");
                }
            }
           
            Console.ReadLine();
