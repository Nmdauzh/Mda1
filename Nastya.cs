using System;

namespace Mda1
{
    public static class Nastya      //Статическая Настя, которая проводит опрос животных
    {
        public static void Show(List<Animal> animals)
        {
            foreach (Animal animal in animals)
                Console.WriteLine(animal.ToString() + animal.Сry() + '\n');
           
        }
        
    }
}
