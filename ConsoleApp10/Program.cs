using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("golden brown");
            //myCar.Colour = "Red";
            Console.WriteLine(myCar.Colour);
            myCar.MyMethod();
            Car myOtherCar = new Car();
            myOtherCar = myCar;
            myOtherCar = null;
            myCar = null;
            myOtherCar = null;

            Console.ReadLine();

        }
    }

    class Car
    {
        public string Colour { get; set; }
        public string ModelName { get; set; }
        public int Year { get; }

        public Car()
        {
            this.Year = 1995;
        }
        public Car(string colour)
        {
            this.Colour = colour;
        }
        public void MyMethod() // instance method - non-static
        {
            Console.WriteLine(this.Colour);
        }
    }
}
