using System;

namespace tasknum3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////a ve b ededinin cemi 2-reqemlidirse "cem ikireqemli ededdir"
            //3 reqemlidirse "cem ucreqemlidir" eks halda "nezere alinmayıb" cap edilsin
            ////a ve b ededinin cemi 2-reqemlidirse "cem ikireqemli ededdir"
            //3 reqemlidirse "cem ucreqemlidir" eks halda "nezere alinmayıb" cap edilsin
            int a = 91;
            int b = 45;
            int c = a + b;
            c = Math.Abs(c);
            if (c / 10 < 10)
            { Console.WriteLine(" iki"); }
            else if (c / 10 < 100 && c / 10 > 10)
            {
                Console.WriteLine("uc");
            }
            else Console.WriteLine("nezere alinmir");
        }
    }
}
