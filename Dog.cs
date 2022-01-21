namespace Mda1.Animals
{
    internal class Dog:Animal
    {
        public uint Bones { get; protected set; }

        public Dog(uint age, uint mass, uint bones = 0) : base(age, mass)   //Это конструктор собаки. Так как она животное, ей
        {                                                               //нужно указать возраст и вес, а так же можно (но не обязательно) указать
            Bones = bones;                                              //колличество костей, которыми она по умолчанию владеет
        }
        public void TakeBone()              //Добавим свой метод для собаки
        {
            Bones++;
        }
        public override string Сry()        //Переопределяем метод крика
        {
            return " Я говорю гав";
        }

        public override string ToString()   //Переопределяем метод 'описывания' с добавлением собачих данных
        {
            string info = "Я собака" + '\n';
            info += base.ToString();
            info += "А ещё у меня " + Bones + " кости";

            return info;
        }
    }
}
