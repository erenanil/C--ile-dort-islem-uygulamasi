using System.Diagnostics;
using System.Security.Cryptography;

namespace pracpracpracpracpracpracprac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate clc = new calculate();
            Console.WriteLine("Girdiğiniz iki sayıyla dört işlem yapan programa Hoş geldiniz!");
            Console.WriteLine("Lütfen ilk değeri giriniz: ");
            int s1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci değeri giriniz: ");
            int s2 = Convert.ToInt16(Console.ReadLine());

            clc.carp(s1, s2);
            if (s2 != 0)
            {
                clc.bol(s1, s2);
            }
            else
            {
                Console.WriteLine("Bölümü: Sıfıra bölme işlemi tanımsızdır.");
            }
            clc.fark(s1, s2);
            clc.topla(s1, s2);
            Console.Read();
        }
    }
}
