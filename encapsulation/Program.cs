using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim1 = "Recep";
            ogrenci.Soyisim="Köseni";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();


            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda",256,1);
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim1;

        private string soyisim;

        private int ogrenciNo;

        private int sinif;

        public string Isim1 { get => isim1; set => isim1 = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
            get => sinif;
            set {
                if (value <= 1) { Console.WriteLine("Sinif En Az 1 Olabilir");
                    sinif = 1;
                }

                else sinif = value;
                }  
        
        }


        public Ogrenci(string isim1, string soyisim, int ogrenciNo, int sinif)
        {
            Isim1 = isim1;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******** Ögrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı : {0}", this.Isim1);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No : {0}", this.ogrenciNo);
            Console.WriteLine("Öğrenci Sinfi : {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;

        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }

   

    
}
