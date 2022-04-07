using System;
using System.Collections;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi=0;
            int avrg1=0 , avrg2=0;
            double avrgtotal=0;
            string avrg1s="" , avrg2s="" ,avrgtotals="";
            ArrayList liste=new ArrayList();
             ArrayList ilkuc=new ArrayList();
              ArrayList sonuc=new ArrayList();
            

        int i=0;

        Console.WriteLine("20 adet tamsayi giriniz ");

        while(i<20)
        {
             sayi=int.Parse(Console.ReadLine()); 

            liste.Add(sayi);

             i++;

        }

        liste.Sort();

            for (int k = 0; k < 3; k++)
            {
                ilkuc.Add(liste[k]);
            }

            for (int k = 17; k < 20; k++)
            {
                sonuc.Add(liste[k]);
            }
   
        Console.WriteLine($"{ilkuc[0]},{ilkuc[1]},{ilkuc[2]} en kücük ilk üc sayilardir");
        
        Console.WriteLine($"{sonuc[0]},{sonuc[1]},{sonuc[2]} en büyük son üc sayilardir");
        

        foreach (int item in ilkuc)
        {
            avrg1+=item;
        }

        
        avrg1s=Convert.ToString(avrg1);
        double avrg1d=double.Parse(avrg1s);
        avrg1d/=3;
        avrg1s=avrg1d.ToString("N2");

        foreach (int item in sonuc)
        {
            avrg2+=item;
        }

       
        avrg2s=Convert.ToString(avrg2);
        double avrg2d=double.Parse(avrg2s);
        avrg2d/=3;
        avrg2s=avrg2d.ToString("N2");

        avrgtotal=avrg1d+avrg2d;
        avrgtotals=avrgtotal.ToString("N2");

        Console.WriteLine("İlk üc sayinin ortalamasi: "+avrg1s);

        Console.WriteLine("Son üc sayinin ortalamasi: "+avrg2s);

        Console.WriteLine("Ortalama toplamlari: "+avrgtotals);
        }
    }
}
