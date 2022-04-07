using System;
using System.Collections;

namespace Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            string a="", c="";
            
            uint avrg1=0, avrg2=0; 
            ArrayList asal=new ArrayList();
            ArrayList asalolmayan=new ArrayList();

            Console.WriteLine("Lütfen 5 adet pozitif tam sayi giriniz");
            
            while(i<20)
            {
                try
                {
                    
                    bool asalmi=true;
                    uint k =uint.Parse(Console.ReadLine());

                   
                    

                        if(k==1) { asalolmayan.Add(1);}

                    
                        else
                        
                        {

                        for(int b=2;b<k;b++)
                        {
                            if(k%b==0) asalmi=false;
                        }

                        if(asalmi) asal.Add(k);

                        else asalolmayan.Add(k);

                        }

                    

                }

               
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Lütfen pozitif ve numeric bir tamsayi giriniz !");

                    continue;
                }

                i++;

            }

            asal.Sort();
            asalolmayan.Sort();



            
            foreach (uint item in asal)
            {
                 avrg1 += item; 

            }
            
            a=Convert.ToString(avrg1);
            double total1=double.Parse(a);
            total1=total1/asal.Count;
           
            string total1s= total1.ToString("N2");  // sonuc x.xx selinde gelmesi icin bu islem yapilmistir

            foreach (uint item in asalolmayan)
            {
                avrg2 += item;                
            }

            c=Convert.ToString(avrg2); // uint ten ortalama islemi direk yapılamadıgı icin int'e cevirme islemi yapıldı
            double total2=double.Parse(c);
            total2=total2/asalolmayan.Count;
            string total2s= total2.ToString("N2");

            Console.WriteLine($"{asal.Count} adet asal sayi vardir.Ortalamalari : " + total1s + " dir");
            Console.WriteLine($"{asalolmayan.Count} adet asal olmayan sayi vardir.ortalamalari : " + total2s + " dir");
            foreach (var item in asal)
            {
                Console.Write($"{item} ");
            }
                Console.Write("\n");
            foreach (var item in asalolmayan)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
