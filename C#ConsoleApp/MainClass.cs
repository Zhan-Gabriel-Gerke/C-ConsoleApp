using System; //import modul
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//"-Текст
//'-Символ
namespace C_ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)//void мы не будем ничего возвращать
        {
            int i;//Обьявление переменной
            for (i = 0; i < 10; i++)//i ++ - Каждое след значение на 1 больше
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------");
            for (int j = i; j > 0; j--)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("-----------");
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("-----DO-----");
            ConsoleKeyInfo key=new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key !=ConsoleKey.Backspace);

            /*
            Console.BackgroundColor = ConsoleColor.Green;//Цвет заднего фона текста
            Console.ForegroundColor = ConsoleColor.Blue;//Цвет текста
            Console.OutputEncoding = Encoding.UTF8;//Кодировка
            Console.WriteLine("Hello world");
            Одностроковый комент
            //Многострочный комент
            //Многострочный комент
            
            //Line - Enter
            int a = 0;
            string tekst = "Python";
            //char taht = 'A';
            //double arv = 1.23456789;
            float arv1 = 2;
            
            Console.WriteLine("Tere!\n" + tekst);
            Console.WriteLine("Tere!\n {0}",tekst);
            Console.Write("Mis on sunu nimi? ");//print
            tekst = Console.ReadLine();//Это как input
            Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
            int vanus = int.Parse(Console.ReadLine());
            string answer = FunktsioonideClass.Jukudef(tekst, vanus);
            Console.WriteLine("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());// int input
            //Console.WriteLine("Arvude {0} ja {1} korrutis vordub {2}", arv1, arv2, arv1*arv2);
            arv1 = FunktsioonideClass.Kalkulaator(a, arv2);//Вызов функции
            Console.WriteLine(arv1);

            Console.WriteLine(a);
            switch (a)
            {
                case 1: tekst = "E"; break;
                case 2: tekst = "T"; break;
                case 3: tekst = "K"; break;
                case 4: tekst = "N"; break;
                case 5: tekst = "R"; break;
                case 6: tekst = "L"; break;
                case 7: tekst = "P"; break;

                default:
                    tekst = "Tundmatu";
                    break;
            }
            */
        }
    }
}