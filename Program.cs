using Mda1.Animals;
using System;

namespace Mda1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3]; //Массив из 3 животных (пока неясно каких)

            animals[0] = new Dog(5, 20, 4);   //Добавили в массив собаку
            animals[1] = new Cat(7, 8, 10);   //Добавили в массив кота
            animals[2] = new Rabbit(13, 4, 7);   //Добавили в массив кролика

            Nastya.Show(animals);       //Как видишь, у собак столько костей, сколько было по умолчанию
                                       //давай дадим каждой собаке из массива по 1 кости
            foreach (Animal animal in animals)
                if (animal is Dog)      //Проверяем, собака ли это
                    ((Dog)animal).TakeBone();   //Если собака - даём кость

            Console.WriteLine("Все кости розданы");
            Nastya.Show(animals);       //Как видишь, у каждой собаки прибавилось по косточке
        }
    }
}
