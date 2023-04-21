namespace Practice_ConstructorsMethodsOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code to test
            Car defaultCar = new Car();
            Car makeModelCar = new Car("Toyota", "Rav4");
            Car fullCar = new Car("Hyundai", "Sonata", 2010, 100000);

            Console.WriteLine("Car Information");
            //3 instances of car using different constructor overload   
            Console.WriteLine(defaultCar.ToString());
            Console.WriteLine(makeModelCar.ToString());
            Console.WriteLine(fullCar.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Bank Information");
            //Test of BankAccount
            BankAccount ba = new BankAccount("12345", "Will Cram", 20);
            Console.WriteLine(ba);
            ba.Deposit(500);
            Console.WriteLine(ba);
            ba.Deposit(-15000);
            Console.WriteLine(ba);
            ba.Withdraw(300);
            Console.WriteLine(ba);
            ba.Withdraw(-500);
            Console.WriteLine(ba);

        }
    }
}