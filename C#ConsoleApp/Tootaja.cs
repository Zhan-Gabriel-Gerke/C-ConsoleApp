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
    public interface ITooline
    {
        double ArvutaPalk();
    }

    /*public class TootajaNaiteks : Inimene, ITooline
    {
        public double Tunnitasu;
        public int Tunnid;

        public double ArvutaPalk()
        {
            return Tunnitasu * Tunnid;
        }

        public override string ToString()
        {
            return $"{Nimi}, Vanus: {Vanus}, Palk: {ArvutaPalk()}";
        }
    }*/
}
