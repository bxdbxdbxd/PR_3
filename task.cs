using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            

        }

        static void Task1()
        {
           var rand= new Random();
            ArrayList arraylist = new ArrayList();
            arraylist.Add(rand.Next( 100));
            arraylist.Add(rand.Next( 100));
            arraylist.Add(rand.Next( 100));
            arraylist.Add(rand.Next(100));
            arraylist.Add(rand.Next(100));
            arraylist.Add("Hello world");
            arraylist.RemoveAt(1);
            for (int i = 0; i < arraylist.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }
            Console.WriteLine($"Количество элементов: {arraylist.Count}");
            string ItemInList = Convert.ToString(Console.ReadLine());
            if (int.TryParse(ItemInList, out int value))
            {
                Console.WriteLine(arraylist.Contains(value));
            }
            else
            {
                Console.WriteLine(arraylist.Contains(ItemInList));
            }
        }

        static void Task2()
        {
            // Шаг a: Создать обобщенную коллекцию List<float> и заполнить её данными
            List<float> floatList = new List<float> { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };

            // Вывести коллекцию на консоль
            Console.WriteLine("Исходная коллекция (List<float>):");
            foreach (var item in floatList)
            {
                Console.WriteLine(item);
            }

            // Шаг b: Удалить из коллекции n элементов
            int n = 2;
            if (n <= floatList.Count)
                floatList.RemoveRange(0, n); // Удаляем первые n элементов
            else
                Console.WriteLine($"Невозможно удалить {n} элементов, так как коллекция содержит лишь {floatList.Count} элементов.");

            // Вывести коллекцию на консоль после удаления
            Console.WriteLine("\nКоллекция после удаления следующих элементов:");
            foreach (var item in floatList)
            {
                Console.WriteLine(item);
            }

            // Шаг c: Добавить другие элементы (используйте все возможные методы добавления)
            floatList.Add(6.6f); // Добавление в конец
            floatList.Insert(0, 0.0f); // Вставка в начало
            floatList.AddRange(new float[] { 7.7f, 8.8f }); // Добавление диапазона
            floatList.InsertRange(1, new float[] { 1.5f, 1.6f }); // Вставка диапазона

            // Вывести коллекцию на консоль после добавления элементов
            Console.WriteLine("\nКоллекция после добавления новых элементов:");
            foreach (var item in floatList)
            {
                Console.WriteLine(item);
            }

            // Шаг d: Создать вторую коллекцию Stack<float> и заполнить её данными из первой коллекции
            Stack<float> floatStack = new Stack<float>(floatList);

            // Вывести вторую коллекцию на консоль
            Console.WriteLine("\nВторая коллекция (Stack<float>):");
            foreach (var item in floatStack)
            {
                Console.WriteLine(item);
            }

            // Шаг f: Найти во второй коллекции заданное значение
            float searchValue = 6.6f;
            Console.WriteLine($"\nИщу значение {searchValue} во второй коллекции:");
            if (floatStack.Contains(searchValue))
            {
                Console.WriteLine($"Значение {searchValue} найдено!");
            }
            else
            {
                Console.WriteLine($"Значение {searchValue} не найдено.");
            }
        }
    }
}
