int[,] dizi = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "]" + "[" + j + "] = ");
                    dizi[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dizi[i, j] + "\t");
                    
                }
                Console.WriteLine("");
                
            }

            for (int m = 0; m < 3; m++)
            {
                int sutuntoplam = 0;
                int satırtoplam = 0;
                int[,] toplam = new int[3, 3];

                for (int n = 0; n < 3; n++)
                {
                    satırtoplam += dizi[m, n];
                    sutuntoplam += dizi[n, m];

                   
                    Console.WriteLine(toplam[n, m] + "\t");

                }
                Console.WriteLine("{0}. Satırın Toplamı\t: {1}\t\t{2}. SütununToplamı\t: {3}", (m + 1), satırtoplam, (m + 1), sutuntoplam);
            }

            Console.ReadLine();
        }


//// Başka char örneği 
             string ad = "bilimsel";
            char[] adi = { 'b', 'i', 'l', 'i', 'm' };

            for (int i = 0; i <ad.Length; i++)
            {
                Console.WriteLine(ad[i]);
            }
            Console.ReadLine();

//// dizide pozitif negatif ayırma
 int n = 0;
            int negatif = 0, pozitif = 0;

            n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];

            

            for (int i = 0; i <sayilar.Length ; i++)
            {
                Console.Write("Sayıyı giriniz..:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

                if (sayilar[i] < 0)
                { 
                    negatif++;
                }
                else if (sayilar[i] > 0)
                { 
                    pozitif++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine("Negatif Sayı Adeti : {0}", negatif);
            Console.WriteLine("Pozitif Sayı Adeti : {0}", pozitif);

            Console.ReadKey();
