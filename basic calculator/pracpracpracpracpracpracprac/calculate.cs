using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracpracpracpracpracpracprac
{
    internal class calculate
    {
        public int topla(int a,int b)
        {
            int c=a+b;
            Console.WriteLine("Toplamı: "+c);
            return c;
        }
        public int fark (int a,int b)
        {
            int c=a-b;
            Console.WriteLine("Farkı: "+c);
            return c;
        }
        public int carp(int a,int b)
        {
            int c=a*b;
            Console.WriteLine("Çarpımı: "+c);
            return c;
        }
        //iki tam sayının bölümü yine bir tam sayı olarak değerlendirilir.
        //Dolayısıyla, double türündeki bir değişkene atama yapılsa bile bu, bölme işleminin gerçek ondalık sonucunu vermeyecektir.
        //Bu yüzden en az bir değişkeni double türünde yazıyoruz.
        public double bol(double a,int b)
        {
            double c = a / b;
            Console.WriteLine("Bölümü: " +c.ToString("0.00"));
            return c;
        }




    }
}
