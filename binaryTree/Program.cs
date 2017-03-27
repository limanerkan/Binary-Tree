using System;

namespace binaryTree
{
    class Program
    {
        static void Main()
        {
            Agac agac = new Agac();
            int eklenecekDeger;

            Random random = new Random();


            for (int i = 0; i <= 20; i++)
            {
                eklenecekDeger = random.Next(1000);
                Console.Write(eklenecekDeger + " ");
                agac.DugumEkle(eklenecekDeger);
            }


            Console.WriteLine("\nOnce kok Gezme");
            agac.OnceKokGezme();


            Console.WriteLine("\nSonra kok Gezme");
            agac.SonraKokGezme();


            Console.WriteLine("\nİç kok Gezme");
            agac.IcKokGezme();

          
        }
    }
}
