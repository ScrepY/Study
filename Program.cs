using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Threading;


namespace Study
{
    class Program
    {


        public static void Main(string[] args)
        {

            Console.Write("Сколько у вас студентов в вузе?: ");
            int students = int.Parse(Console.ReadLine());

            string[] name = new string[students];

            byte[] age = new Byte[students];

            for (int i = 0; i < students; i++)
            {

                Console.Write("Как вас зовут?: ");
                name[i] = Console.ReadLine();


                Console.Write("Сколько вам лет?: ");

                age[i] = byte.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine($"Количество учеников в ВУЗЕ: {students}");
            Thread.Sleep(2000);



            for (int i = 0; i < students; i++)
            {

                Console.WriteLine($"Имя: {name[i]}");
                Console.WriteLine($"Возраст: {age[i]}");
                if (name.Length <= 5)
                {
                    Thread.Sleep(100);
                    Console.WriteLine();
                }

                else if (name.Length <= 2)
                {
                    Thread.Sleep(300);
                    Console.WriteLine();
                }
                else if (name.Length <= 5)
                {
                    Thread.Sleep(400);
                    Console.WriteLine();
                }
                else if (name.Length <= 10)
                {
                    Thread.Sleep(500);
                    Console.WriteLine();
                }
                else if (name.Length <= 15)
                {
                    Thread.Sleep(400);
                    Console.WriteLine();
                }
                else
                {
                    Thread.Sleep(200);
                    Console.WriteLine();
                }
            }


            Console.ReadLine();




        }
    }


}
