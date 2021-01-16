using System;

namespace KampIntro_2.Hafta_Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";
            bu tip verilerimizi arraylerde yani dizilerde tutarız.
            yani tek bir stringi değil birden falza stringi tek bir dizide tutmak istiyorum.
             */

            //ARRAY-DİZİ
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java","Python","C++"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti.");

            foreach (string kurs in kurslar)//buradaki kurs allias-takma isimdir.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
