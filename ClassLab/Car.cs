using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab
{
    public class Car
    {
        public static int NumberOfCars { get; set; }

        public double MaxSpeed;
        public string Color;

        public string RegNumber { get; private set; }

        public bool IsFast
        {
            get
            {
                return MaxSpeed > 100;
            }
        }


        public Car() : this("N/A") {}

        public Car(string regNumber) : this(regNumber, 0) {}

        public Car(string regNumber, double maxSpeed)
        {
            NumberOfCars++;
            RegNumber = regNumber;
            MaxSpeed = maxSpeed;
        }

        public static void PrintNumberOfCars()
        {
            Console.WriteLine($"I have {Car.NumberOfCars} cars");
        }

        public static void PrintReg(Car car)
        {
            Console.WriteLine($"Reg is {car.RegNumber}");
        }

        public void SetNewRegNumber(string regNumber)
        {
            RegNumber = regNumber.ToUpper();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Regnumber: {RegNumber}, Max speed: {MaxSpeed}");
        }

        public bool IsFasterThan(double speed)
        {
            return MaxSpeed > speed;
        }

        public bool IsFasterThan(int speed)
        {
            return IsFasterThan((double)speed);
        }
    }
}
