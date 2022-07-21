using System;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> d372b43a02d9bbc55f17774564be9e9c97b2b689

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
<<<<<<< HEAD
            Console.WriteLine("");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create new file");
            Console.WriteLine("0 - Exit");

=======
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create new file");
            Console.WriteLine("0 - Exit");
>>>>>>> d372b43a02d9bbc55f17774564be9e9c97b2b689
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;

                case 1: Open(); break;

                case 2: Edit(); break;

                default: Menu(); break;
            }
        }

        static void Open()
        {
<<<<<<< HEAD

=======
            Console.Clear();
            Console.WriteLine("File path to open?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
>>>>>>> d372b43a02d9bbc55f17774564be9e9c97b2b689
        }

        static void Edit()
        {
            Console.Clear();
<<<<<<< HEAD
            Console.WriteLine("Type your text");
            Console.WriteLine("");
            Console.WriteLine("Press Esc to exit");
            Console.WriteLine("------------------------");

=======
            Console.WriteLine("Write your text below the line. (ESC to leave)");
            Console.WriteLine("--------------------------------");
>>>>>>> d372b43a02d9bbc55f17774564be9e9c97b2b689
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
<<<<<<< HEAD
        }

        static void Save()
        {
            Console.Clear();
            Console.WriteLine("Which path to save the file?");

=======

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("What path to save the file?");
>>>>>>> d372b43a02d9bbc55f17774564be9e9c97b2b689
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File {path} successful saved.");
<<<<<<< HEAD
=======
            Console.ReadLine();
>>>>>>> d372b43a02d9bbc55f17774564be9e9c97b2b689
            Menu();
        }
    }
}