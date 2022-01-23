using Mda1.Animals;
using System;
using System.IO;

namespace Mda1
{
    class AnimalsIO
    {
        public static void SaveToFile(List<Animal> animals, string path);

        public static List<Animal> GetFromFile(in string path);
        
    }
}