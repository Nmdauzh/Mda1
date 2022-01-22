using Mda1.Animals;
using System;
using System.Collections.Generic;

namespace Mda1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
               
            };


            Nastya.Show(animals);       
            foreach (Animal animal in animals)
                if (animal is Dog)      //Проверяем, собака ли это
                    ((Dog)animal).TakeBone();   //Если собака - даём кость

            Console.WriteLine("Все кости розданы");
            Nastya.Show(animals);       //Как видишь, у каждой собаки прибавилось по косточке
        }
    }
}
