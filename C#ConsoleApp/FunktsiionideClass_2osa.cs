using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    class FunktsiionideClass_2osa
    {
        public static List<string> Sonad()
        {
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Nimi: ");
                sonad.Add(Console.ReadLine());
            }
            foreach (var item in sonad)
            {
                Console.WriteLine(item);
            }
            return sonad;
        }
    }
}
