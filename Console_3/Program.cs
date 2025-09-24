using System.Runtime.CompilerServices;

namespace Console_3
{
    internal class Program
    {
        static List<string> list = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();

                string ans = CheckWord();
                SwitchMenu(ans);
                Console.ReadKey();
            }
        }

        static void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("List - Lista elemek kiírása");
            Console.WriteLine("Add - Hozzáad egy elemet");
            Console.WriteLine("Clear - Kitörli az összes elemet");
            Console.WriteLine("Remove - Kitörli a megadott elemet");
            Console.WriteLine("Exit - Kilép az alkalmazásból\n");
        }

        static void SwitchMenu(string word)
        {
            switch (word.ToLower())
            {
                case "list": functionListAll();
                    break;
                case "add": functionAdd();
                    break;
                case "clear": functionClear();
                    break;
                case "remove": functionRemove();
                    break;
                case "exit": functionExit();
                    break;
                default: Console.WriteLine("Hibás menüpont");
                    break;
            }
        }

        static string CheckWord()
        {
            Console.Write("Add meg a kiválasztott opciót: ");
            string wordTo = Console.ReadLine().Trim();
            return wordTo;
        }

        static void functionListAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine(" Üres a lista.");
            }
            else
            {
                Console.WriteLine("Lista:");
                Console.WriteLine(string.Join(", ", list));
            }
        }

        static void functionAdd()
        {
            Console.Write("Adj meg egy szót,: ");
            string StringAddList = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(StringAddList))
            {
                Console.WriteLine("Üres értéket nem.");
                return;
            }

            bool onlyLetters = true;
            foreach (char c in StringAddList)
            {
                if (!char.IsLetter(c))
                {
                    onlyLetters = false;
                    break;
                }
            }

            if (onlyLetters)
            {
                list.Add(StringAddList);
                Console.WriteLine("Hozzáadva");
            }
            else
            {
                Console.WriteLine("Csak betűkből álló szót adhatsz meg!");
            }
        }

        static void functionClear()
        {
            list.Clear();
            Console.WriteLine("A lista összes eleme törölve.");
        }

        static void functionRemove()
        {
            Console.Write("Add meg az eltávolítandó elemet: ");
            string itemToRemove = Console.ReadLine().Trim();
            if (list.Remove(itemToRemove))
            {
                Console.WriteLine($"'{itemToRemove}' eltávolítva a listából.");
            }
            else
            {
                Console.WriteLine($"'{itemToRemove}' nem található a listában.");
            }
        }

        static void functionExit()
        {
            Console.WriteLine("Kilépés az alkalmazásból...");
            Environment.Exit(0);
        }
    }
}