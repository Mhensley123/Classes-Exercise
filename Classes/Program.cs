namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Audi";
            myCar.Model = "A8";
            myCar.Year = 2023;
            
            var acura = new Car()
            {
                Make = "Acura",
                Model = "MDX",
                Year = 2023
            };

            var hyundai = new Car("Hyundai", "Genesis", 2023);

            var carList = new List<Car>() {myCar, acura,hyundai};
            Console.WriteLine(carList.Capacity);

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
