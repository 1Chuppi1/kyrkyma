using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            Console.WriteLine(hello + " " + world);
            Console.ReadLine();

            int a = 5;
            int b = 2;
            Console.WriteLine(a + b); //Сложение
            Console.WriteLine(a - b); // Вычитание
            Console.WriteLine(a * b); // Умножение
            Console.WriteLine(a / b); // Деление

            Console.ReadLine();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введит отчество: ");
            string patronymic = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {surname} {name} {patronymic}!");
            Console.ReadLine();

            int pH = 100;
            int pDam = 20;
            int pDef = 10;

            int mH = 80;
            int mDam = 15;
            int mDef = 5;

            int damageToPlayer = (mDam - pDef) < 0 ? 0 : (mDam - pDef);
            int damageToMonster = (pDam - mDef) < 0 ? 0 : (pDam - mDef);

            pH -= damageToPlayer;
            mH -= damageToMonster;

            Console.WriteLine($"Здоровье игрока: {pH}");
            Console.WriteLine($"Здоровье Монстра: {mH}");
            Console.WriteLine($"Игрок нанеc урона: {damageToMonster}");
            Console.WriteLine($"Монстр нанес урона: {damageToPlayer}");
            Console.ReadLine() ;
        }
    }
}
