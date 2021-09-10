using System;

namespace Password_check
{
    class Password_Check
    {     
        public static void Main()
        {
            //Константа пароля
            const string passwordExemple = "PASSWORD";
            //Переменная пароля введенного в командной строке
            string password;

            //Ввод пароля в командную страку и присвоение его переменной password
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();

            //Сравнение введенного пароля с константой
            if (password == passwordExemple)
            {
                Console.WriteLine("Пароль подтвержден!");
            }
            else
            {
                Console.WriteLine("Неверный пароль!");
            }

            //Ожидание ввода для завершения программы
            Console.ReadKey();
        }
    }
}
