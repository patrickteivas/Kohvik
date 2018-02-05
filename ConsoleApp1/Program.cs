using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tere! ");
            bool checkMenu = false;
            int checkedValik;
            while (checkMenu == false)
            {
                Console.WriteLine("Mida te soovite osta?\n1. Kohv\n2. Toit");
                var valik = Console.ReadLine();
                checkMenu = Int32.TryParse(valik, out checkedValik);
                if (checkMenu == true)
                {
                    var Menu = new Menu();
                    if (checkedValik == 1)
                    {
                        Menu.Kohv();
                    }
                    else if (checkedValik == 2)
                    {
                        Menu.Toit();
                    }
                    else
                    {
                        checkMenu = false;
                        Console.Clear();
                        Console.WriteLine("Vale valik!\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale valik!\n");
                }
            }
            //
        }
    }
}
