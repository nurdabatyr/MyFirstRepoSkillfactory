using System;  // Подключенное пространство имен

namespace SkillFacotryLessonCsharp.FirstApp  // Объявление пространства имен для данного кода
{ 

class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            Console.WriteLine("Как вас зовут?"); // Действия внутри метода
            string name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?"); // Действия внутри метода
            string age = Console.ReadLine();
            Console.WriteLine("Чем вы занимаетесь?"); // Действия внутри метода
            string hobby = Console.ReadLine();
<<<<<<< HEAD
      
=======

            string myName2 = "Nurdaulet";
>>>>>>> 18e2aa97cff676617fed03140bdebf36f93416d2
            string myName3 = "Nurdaulet";


            Console.WriteLine("Здравствуйте , {0}", name);
            Console.WriteLine("Мне сообщили что вам {0}  лет", age);
            Console.WriteLine("Наверное, {0} - очень интересное занятие. Мне стоит попробовать", hobby);
            Console.WriteLine("Рад был познакомиться!");
            Console.WriteLine(myName3);
<<<<<<< HEAD
           
=======
            Console.WriteLine(myName2);

>>>>>>> 18e2aa97cff676617fed03140bdebf36f93416d2
        }
    }
}