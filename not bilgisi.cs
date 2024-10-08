using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace derslerinotpuaninagöreharflendirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 tane not ortalaması isteyip bunların ortalamasını alan 
            //80-100 arasındaysa A 
            //60-80 arasındaysa B 
            //40-60 arasındaysa C 
            //40 dan küçük ise F 

            Console.WriteLine("lütfen 1. notunuzu girin");
            int birinci_not = Convert.ToInt32(Console.ReadLine());

            int ikinci_not = Convert.ToInt32(Console.ReadLine());

            int ücüncü_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ücüncü_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("not degeriniz: A dır");
            }
            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("not degeriniz: B dir");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("not degeriniz : C dir");
            }
            else
            {
                Console.WriteLine("not degeriniz : F dir");
                Console.ReadLine();
            }

        }
    }
}