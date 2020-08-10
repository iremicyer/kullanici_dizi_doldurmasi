using System;

namespace Dizi_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("dizi boyutunu giriniz:"); // kullancııdan dizi boyutu alınması
            int boyut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] dizi = new int[boyut];
            string[] öğrenci = new string[boyut]; // bir öğrenci dizisinin oluşturulması.

            for (int i = 0; i < boyut; i++)
            {
                Console.Write("öğrenci adini giriniz:"); // kullanıcıdan, girilen boyut kadar isim alınması
                öğrenci[i] = Console.ReadLine();
            }
            Console.WriteLine("---------------------------");
   
        }
    }
}
