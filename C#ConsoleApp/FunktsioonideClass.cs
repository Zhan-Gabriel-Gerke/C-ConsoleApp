using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace C_ConsoleApp
{
    internal class FunktsioonideClass
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulator = 0;
            kalkulator = arv1 * arv2;
            return kalkulator;
        }
        public static string Jukudef(string tekst, int vanus)
        {
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Lahme kinno!");
                try
                {
                    if (vanus <= 0 || vanus > 100) // || - or, && - and
                    {
                        return ("Viga");
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        return ("Tasuta");
                    }
                    else if (vanus <= 15)
                    {
                        return ("Lastepilet");
                    }
                    else if (vanus <= 65)
                    {
                        return ("TaisPilet");
                    }
                    else if (vanus <= 100)
                    {
                        return ("Sooduspilet!");
                    }
                }
                catch (Exception e)
                {
                    return ("Viga");
                }
            }
            else
            {
                return("Olen hoivatud!");
            }
        }

    }
}
