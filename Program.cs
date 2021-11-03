using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = DateTime.Now.Month;
            switch (mounth)
            {
                case 1:
                Console.WriteLine("ocak ayındasınız");
                break;
                case 2:
                Console.WriteLine("şubat ayındasınız"); 
                break;
                case 3:
                Console.WriteLine("mart ayındasınız");
                break;
                case 4:
                Console.WriteLine("nisan ayındasınız");
                break;
                
                default:
                Console.WriteLine("hatalı veri girişi");
                break;
                
            }
        }
    }
}
