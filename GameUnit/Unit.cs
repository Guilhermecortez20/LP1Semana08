namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;

        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"Moveu {ToRoman(movement)} casas.");
        }

        public static string ToRoman(int number)
        {
            if (number < 1 || number > 3999) return "Número inválido";

            string[] milhares = { "", "M", "MM", "MMM" };
            string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] dezenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return milhares[number / 1000] +
                   centenas[(number % 1000) / 100] +
                   dezenas[(number % 100) / 10] +
                   unidades[number % 10];
        }

        public abstract float Cost { get; }
    }
}
