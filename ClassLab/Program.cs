namespace ClassLab
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Russian doll övning 1
            //RussianDoll currentDoll = new RussianDoll();
            //RussianDoll firstDoll = currentDoll;
            //for (int i = 0; i < 4; i++) {
            //    currentDoll.innerDoll = new RussianDoll();
            //    currentDoll = currentDoll.innerDoll;
            //}

            //Console.WriteLine(CountDolls(firstDoll));


            // Instanser och metoder
            //Car myCar = new Car("ABC 123", 107);

            //myCar.PrintInfo();


            // Övning 2 Skolklass
            //SchoolClass net23 = new SchoolClass()
            //{
            //    Name = "NET23",
            //    NumberOfStudents = 38,
            //};

            //net23.PrintInfo(32);


            // Properties
            //Car myCar = new Car("ABC 123", 100);
            //myCar.RegNumber = "AAA 444";

            // Övning 3 Properties
            //Person me = new Person();
            //me.Name = "Christoffer";
            //me.Name = "Karl";
            //Console.WriteLine(me.Name);


            // Beräknade properties
            //Car myCar = new Car("ABC 123", 120);
            //Console.WriteLine($"Isfast: {myCar.IsFast}");

            // Övning 4 Uträknad property
            //Person person = new Person();
            //person.Age = 100;
            //Console.WriteLine($"Person is {person.Age}. Is retired: {person.IsRetired}");


            //Car.PrintNumberOfCars();
            //Car car = new Car();
            //Car otherCar = new Car();
            //Car extraOtherCar = new Car();
            //Car.PrintNumberOfCars();
            //Car.PrintReg(extraOtherCar);

            // Övning 6 static method
            Person p1 = new Person();
            p1.Age = 50;
            Person p2 = new Person();
            p2.Age = 20;
            Console.WriteLine($"Oldest person is {Person.Oldest(p1, p2).Age} years old");

        }

        static int CountDolls(RussianDoll doll)
        {
            RussianDoll currentDoll = doll;
            int count = 1;
            while (currentDoll.innerDoll is not null) {
                count++;
                currentDoll = currentDoll.innerDoll;
            }
            return count;
        }
    }
}