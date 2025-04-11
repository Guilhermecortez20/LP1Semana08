namespace GameUnit
{
    internal class Program
    {
        static void Main()
        {
            MilitaryUnit soldier = new MilitaryUnit(3, 10, 2);
            SettlerUnit settler = new SettlerUnit();

            Console.WriteLine("Soldado:");
            soldier.Move();
            Console.WriteLine($"Health: {soldier.Health}, Cost: {soldier.Cost}");

            Console.WriteLine("\nColono:");
            settler.Move();
            Console.WriteLine($"Health: {settler.Health}, Cost: {settler.Cost}");

            Console.WriteLine("\nSoldado ataca colono!");
            soldier.Attack(settler);
            Console.WriteLine($"Colono após ataque - Health: {settler.Health}");
            Console.WriteLine($"Soldado após ataque - XP: {soldier.XP}, Health: {soldier.Health}, Cost: {soldier.Cost}");
        }
    }
}
