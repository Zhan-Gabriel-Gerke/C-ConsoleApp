using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    public class Tootaja : Inimene
    {
        public string Ametikoht;

        public void Tootan()
        {
            Console.WriteLine($"{Nimi} works as {Ametikoht}.");
        }
    }

}
