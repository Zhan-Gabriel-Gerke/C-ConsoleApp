using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    public abstract class Loom
    {
        public string Nimi;
        public abstract void TeeHaal();
    }
    public class Koer : Loom
    {
        public override void TeeHaal()//override - переопределить
        {
            Console.WriteLine("Au-Au!");
        }
    }
    public class Kass : Loom
    {
        public override void TeeHaal()
        {
            Console.WriteLine("Mjau");
        }
    }
}
