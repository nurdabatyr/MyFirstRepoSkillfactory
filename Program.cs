using System;
using System.Runtime;  // Подключенное пространство имен
using System.Linq;

namespace SkillFacotryLessonCsharp.FirstApp  // Объявление пространства имен для данного кода
{

    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            /*Console.WriteLine("Как вас зовут?"); // Действия внутри метода
            string name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?"); // Действия внутри метода
            string age = Console.ReadLine();
            Console.WriteLine("Чем вы занимаетесь?"); // Действия внутри метода
            string hobby = Console.ReadLine();

            Console.WriteLine("Здравствуйте , {0}", name);
            Console.WriteLine("Мне сообщили что вам {0}  лет", age);
            Console.WriteLine("Наверное, {0} - очень интересное занятие. Мне стоит попробовать", hobby);
            Console.WriteLine("Рад был познакомиться!");*/

            /*DaysOfWeek MyFavoriteDay = DaysOfWeek.Friday;
             Semaphore Semaphore = Semaphore.Red;


             string name = "Nurdaulet";
             Console.WriteLine("Hello Wordl");
             Console.WriteLine($"My name is ={name}");

             Console.WriteLine(MyFavoriteDay);
             Console.WriteLine(Semaphore);
             int age = 27;
             string favcolor = "Black";
             Console.WriteLine($"{name}\n  {age}\n {favcolor}");
             Console.ReadKey();*/

            /*double result = 5.0 % 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            Console.ReadKey();*/

            /*int numb_1 = 25;
            numb_1++;
            Console.WriteLine(numb_1);
            ++numb_1;
            Console.WriteLine(numb_1);
            Console.WriteLine(numb_1++);
            Console.WriteLine(++numb_1);
            Console.ReadKey();*/
            /*
                        var color = Console.ReadLine();

                        switch (color)
                        {
                            case "red":
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine("Your color is red!");
                                break;

                            case "green":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine("Your color is Green!");
                                break ;

                               case "blue":
                                  Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine("Your color is Blue!");
                                break;

                                default:
                                 Console.BackgroundColor = ConsoleColor.Cyan ;
                                     Console.ForegroundColor = ConsoleColor.Black  ;

                                    Console.WriteLine("Your color is cyan!");
                                break;
                        }*/


            /*  Console.WriteLine("Введите ваше имя");
              string name = Console.ReadLine();
              for (int i = name.Length-1; i >= 0 ; i--)
              {
                  Console.Write(name[i] + " ");
              }*/

            /* int[,] array = { { 1, 2, 3, 4 }, { 5, 6, 7 ,5} };
             Console.WriteLine(array.Length);
             Console.WriteLine(array.GetUpperBound(0)+1);*/
            //Написать программу который после ввода имений, переделают наоброт по буквам

            /*Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            for (int i=name.Length-1; i>=0;i--)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();*/


            /*int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 }};
            Console.WriteLine("0= " +array.GetUpperBound(0));
            Console.WriteLine("1= " +array.GetUpperBound(1));
            Console.WriteLine("array 1 2= " + array[3,2]);

            for (int i = 0; i < array.GetUpperBound(1)+1 ; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }*/


            /* var arr = new int[] { 5, 6, 9, 1, 2, 3, 4};   

             int n = arr.Length;
             for (int i = 0; i < n - 1; i++)
             {
                 for (int j = 0; j < n - 1 - i; j++)
                 {
                     if (arr[j] > arr[j + 1])
                     {
                         // Обмен элементов
                         int temp = arr[j];
                         arr[j] = arr[j + 1];
                         arr[j + 1] = temp;
                     }
                 }
             }


             foreach (int ch in arr)
                 Console.Write(ch + " ");

             Console.WriteLine("\n arr lenght = " + arr.Length);*/  //сортировка массива по возростанию


            //var arr = new int[] { -66, 5, 6, 9, 1, 2, 3, 4,-5,-71 }; // находим сумму всех элементов массива
            /*int[,] arr = new int[,] { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int sum = 0;
    
                foreach (var ch in arr)
                {
                    if (ch > 0)
                        sum++;
                }
            

            Console.Write("Sum=" + sum);*/

            /* int[][] array = new int[3][];

             array[0] = new int[2] { 1, 2 };
             array[1] = new int[3] { 1, 2, 3 };
             array[2] = new int[5] { 1, 2, 3, 4, 5 };

             foreach (var num in array)
             {
                 foreach (var item in num)
                 {
                     Console.Write(item + " ");
                 }
                 Console.WriteLine();
             }*/
         
            (string name,string surname, int age, string color1, string color2, string pet, string login, string password) user;
            Console.WriteLine("Заполняем поля:");
            Console.WriteLine("Ваше имя:");
            user.name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            user.surname = Console.ReadLine();
            Console.WriteLine("Ваш возраст:");
            user.age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш питомец:");
            user.pet = Console.ReadLine();
            Console.WriteLine("Ваш первый цвет:");
            user.color1 = Console.ReadLine();
            Console.WriteLine("Ваш второй цвет:");
            user.color2 = Console.ReadLine();

            Console.WriteLine("Вашы данные:");
            Console.WriteLine($"Ваше имя: {user.name}");
            Console.WriteLine($"Ваше фамилия: {user.surname}");
            Console.WriteLine($"Ваш возраст: {user.age}");
            Console.WriteLine($"Ваш питомец: {user.pet}");
            Console.WriteLine($"Ваш цвет1: {user.color1}");
            Console.WriteLine($"Ваш цвет2: {user.color2}");

            

            Console.ReadKey();
        }

        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday = 22
        }

        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}