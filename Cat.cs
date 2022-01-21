namespace Mda1.Animals
{
    internal class Cat : Animal
    {
        public uint Fish { get; protected set; }

        public Cat(uint age, uint mass, uint fish = 0) : base(age, mass)   //Это конструктор собаки. Так как она животное, ей
        {                                                               //нужно указать возраст и вес, а так же можно (но не обязательно) указать
            Fish = fish;                                              //колличество костей, которыми она по умолчанию владеет
        }
        public void TakeFish()              //Добавим свой метод для собаки
        {
            Fish++;
        }
        public override string Сry()        //Переопределяем метод крика
        {
            return " Я говорю мяу";
        }

        public override string ToString()   //Переопределяем метод 'описывания' с добавлением собачих данных
        {
            string info = "Я кошка" + '\n';
            info += base.ToString();
            info += "А ещё у меня " + Fish + " рыбок";

            return info;
        }
    }
}
