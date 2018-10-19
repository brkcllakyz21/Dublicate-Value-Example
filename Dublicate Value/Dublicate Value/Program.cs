using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublicate_Value
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = new int[10];
            int sayı = 0;
            bool kontrol_1 = false;
            for (int i = 0; i <= dizi.GetUpperBound(0); i++)
            {
                Console.Write("10 ile 100 arasında bir tam sayı giriniz = ");
                sayı = Convert.ToInt32(Console.ReadLine());
                while (sayı < 10 || sayı > 100)
                {
                    Console.Write("10 ile 100 arasında bir tam sayı giriniz = ");
                    sayı = Convert.ToInt32(Console.ReadLine());
                }
                for (int j = 0; j <= dizi.GetUpperBound(0); j++)
                {
                    if (sayı == dizi[j])
                    {
                        kontrol_1 = true;
                    }
                }
                if (kontrol_1)
                {
                    i--;
                    kontrol_1 = false;
                }
                else
                {
                    dizi[i] = sayı;
                    kontrol_1 = false;
                    Console.WriteLine("dizi[" + i + "] = " + dizi[i]);
                }
            }





        }
    }
}
