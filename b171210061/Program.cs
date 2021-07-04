// Ece Nur ARSLAN
// B171210061
// 1. Öğretim A grubu

using System;

namespace B171210061
{
    public class Program
    {

        public static void Main()
        {
            string ifade;
            Console.WriteLine("Kontrol edilecek regüler ifadeyi giriniz: ");
            ifade = Console.ReadLine();
            bool inAlphabet = false;

            string allowableLetters = "ab";

            foreach (char c in ifade)
            {
                if (allowableLetters.Contains(c.ToString()))
                    inAlphabet = true;
            }

            if (inAlphabet & !(ifade.Contains(" "))) A(ifade);
            else Console.WriteLine("Girilen ifade bu dile uygun DEĞİLDİR.");

            Console.ReadKey();


        }
        static void A(string ifade)
        {
            if (ifade.StartsWith("b") | (ifade.Length == 1 & ifade == " "))
            {
                Console.WriteLine("Girilen ifade bu dile uygun DEĞİLDİR.");
                return;
            }

            if (ifade.Length == 0)
            {
                Console.WriteLine("Girilen ifade bu dile uygundur.");
                return;
            }

            if (ifade.StartsWith("a"))
            {
                B(ifade.Substring(1));
            }


        }

        static void B(string ifade)
        {
            if (ifade.StartsWith("a"))
            {
                C(ifade.Substring(1));
            }

            if (ifade.StartsWith("b"))
            {
                D(ifade.Substring(1));
            }

            if (ifade.Length == 0)
            {
                Console.WriteLine("Girilen ifade bu dile uygundur.");
                return;
            }

        }

        static void C(string ifade)
        {
            if (ifade.Length == 0)
            {
                Console.WriteLine("Girilen ifade bu dile uygundur.");
                return;
            }

            if (ifade.StartsWith("a"))
            {
                E(ifade.Substring(1));
            }

            if (ifade.StartsWith("b"))
            {
                A(ifade.Substring(1));
            }

        }

        static void D(string ifade)
        {
            if (ifade.Length == 0 | ifade.StartsWith("b"))
            {
                Console.WriteLine("Girilen ifade bu dile uygun DEĞİLDİR.");
                return;
            }

            if (ifade.StartsWith("a"))
            {
                F(ifade.Substring(1));
            }

        }

        static void E(string ifade)
        {
            if (ifade.Length == 0)
            {
                Console.WriteLine("Girilen ifade bu dile uygundur.");
                return;
            }

            if (ifade.StartsWith("a"))
            {
                E(ifade.Substring(1));
            }

            if (ifade.StartsWith("b"))
            {
                D(ifade.Substring(1));
            }

        }

        static void F(string ifade)
        {
            if (ifade.Length == 0)
            {
                Console.WriteLine("Girilen ifade bu dile uygundur.");
                return;
            }

            if (ifade.StartsWith("a"))
            {
                E(ifade.Substring(1));
            }

            if (ifade.StartsWith("b"))
            {
                Console.WriteLine("Girilen ifade bu dile uygun DEĞİLDİR");
                return;
            }

        }
    }

}
