# Banka uygulaması basit
int islem,bakiye=1000,tutar;
    printf("islemler\n1=Para Cekme\n2=Para Yatirma\n3=Bakiye Sorgulama\n4=Kart iade \n");
    printf("islem seciniz=");
    scanf("%d",&islem);
    switch(islem){
	
    	
    	case 1:
		    printf("Bakiyeniz=%d\n",bakiye);
		    printf("Cekmek istediginiz tutari giriniz=");
		    scanf("%d",&tutar);
		    if(tutar>1000)
			{
			printf("Yetersiz miktar girdiniz!\nYeniden giriniz=");
		    scanf("%d",&tutar);
			}
		    bakiye=bakiye-tutar;
		    printf("Yeni Bakiyeniz=%d",bakiye);
		    break;
		case 2:
		    printf("Bakiyeniz=%d\n",bakiye);
		    printf("Yatirmak istediginiz tutari giriniz=");
		    scanf("%d",&tutar);
		    bakiye=bakiye+tutar;
		    printf("Yeni Bakiyeniz=%d",bakiye);
		    break;	
		case 3:
		    printf("Bakiyeniz=%d\n",bakiye);
		    break;	
		case 4:
		    printf("Kartinizi almayi unutmayin!");
		    break;	
				
	}
	return 0;
# sayı ortalama alma

int main(int argc, char** argv) {
	int i=1,toplam=0,bolme=0;
       while (i<=100)/*For dongusu ile sayilari birer birer 100e kadar arttiriyoruz..*/

       {
       	   i++;
           toplam += i;
       }

      printf("1'den 100'e kadar olan sayilarin toplami = %d'dir..",toplam);
	  bolme=toplam/100;	
	  printf("ortalamasi =%d ",bolme);
      
      char();
      return 0;
  
 # sayı ortalama alama 
  
    int sayi,toplam = 0,i;

     printf("Bir sayi giriniz : ");
     scanf("%d",&sayi);

     while(i<sayi){
          toplam = toplam + i;
          i++;
     }

     printf("0 ile %d arasindaki sayilarin toplami : %d ", sayi, toplam);
