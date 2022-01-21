namespace Mda1
{
    public abstract class Animal
    {
        public uint Age { get; protected set; } = 0;
        public uint Mass { get; protected set; } = 0;
        public uint CoutOfJumps { get; protected set; } = 0;

        public Animal(uint age, uint mass)  //Конструктор для абстрактного животного (то есть, чтобы создать ЛЮБОЕ животное)
        {                                   //Требуется указать его возраст и вес (так как без веса животных не бывает)
            Age = age;
            Mass = mass;
            
        }

        public void Jump()                  //Прыжок. Все звери умеют прыгать, так что он неизменен
        {
            CoutOfJumps++;
        }

        public override string ToString()   //Метод 'описывания', будет выводить инфу о животном, которая есть у всех
        {
            string info = "Мне " + Age + " лет" + '\n';
            info += "Я вешу " + Mass + " кг" + '\n';
            info += "Я подпрыгнул уже " + CoutOfJumps + " раз" + '\n';

            return info;
        }
        public abstract string Сry();   //Крик. Пока что ничего не делает, так как все звери кричат по разному
        
    }
}
