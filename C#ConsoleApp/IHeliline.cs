using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleApp
{
    public interface IHeliline
    {
        void TeeHääl();
    }

    public class Cat : IHeliline
    {
        public void TeeHääl()
        {
            Console.WriteLine("Mjay!");
        }
    }

}
