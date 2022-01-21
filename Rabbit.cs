namespace Mda1.Animals
{
    internal class Rabbit: Animal
    {
        public uint Birth { get; protected set; }

        public Rabbit(uint age, uint mass, uint birth = 0) : base(age, mass) 
        {
            Birth = birth;
        }
             public override string Сry()        //Переопределяем метод крика
        {
            return " Я издают странные звуки, которые сложно описать";
        }
        public void GivingBirth()              //Добавим свой метод для собаки
        {
            Birth++;
        }


        public override string ToString()   //Переопределяем метод 'описывания' с добавлением собачих данных
        {
            string info = "Я кролик" + '\n';
            info += base.ToString();
            info += "А ещё у меня родилось " + Birth + " крольчат";


            return info;
        }
    }
}
