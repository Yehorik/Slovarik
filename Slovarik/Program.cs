using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Slova

{
    class Diction
    {
        string rus;
        string engl;
        public string Rus
        {
            get
            {
                return rus;
            }
            set
            {
                rus = value;
            }
        }
        public string Engl
        {
            get
            {
                return engl;
            }
            set
            {
                engl = value;
            }
        }
        public Diction(string Rus1, string Engl1)
        {
            Rus = Rus1;
            Engl = Engl1;
        }

        public override string ToString()
        {
            return string.Format("Перевод:" + Engl);
        }
    }
    class Program

    {
        static void Nahod(Diction d1, string s1)
        {
            if (s1 == d1.Rus)
                Console.WriteLine(d1.ToString());
        }
        static void Main(string[] args)
        {
            List<Diction> Dict = new List<Diction>();
            string s1;
            string s2;
            do
            {
                Console.WriteLine("Введите русское слово или 'q' для выхода из режима добавления слов");
                s1 = Console.ReadLine();
                if (s1 == "q") break;
                Console.WriteLine("Введите английское значение слова");
                s2 = Console.ReadLine();
                Dict.Add(new Diction(s1, s2));
            } while (s1 != "");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите русское слово для перевода");
            string s3 = Console.ReadLine();
            foreach (Diction dic in Dict)
            {
                Nahod(dic, s3);
            }
            Console.ReadKey();
        }
    }
}