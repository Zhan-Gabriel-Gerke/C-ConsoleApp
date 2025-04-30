using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    public class Inimene
    {
        public string Nimi;
        public int Vanus;
        public void Tervita()
        {
            Console.WriteLine("Hello! I'm — " + Nimi);
        }
    }
}
