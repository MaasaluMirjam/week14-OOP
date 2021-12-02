using System;

namespace OOPcar
{
    class Program
    {            
       class Car
       { 
        
         string mark;
         string model;
         string regNumber;
         string color;
         int odo;
         int fuelTank;

           public Car(string _mark, string _model, string _regNumber, string _color)
           {
              mark = _mark;
              model = _model;
              regNumber = _regNumber;
              color = _color;
              odo = 0;
              fuelTank = 60;

              Console.WriteLine($"{color} {mark} {model} {regNumber} has been created.");
           }               
           public int FuelTank
           {
              get { return fuelTank; }
           }
           public void Drive()
           {
                fuelTank -= 5;
                odo += 100;
                Console.WriteLine("Vroom-vroom");
           }
           public void ShowCarData()
           {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Registration Number: {regNumber}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odometer: {odo}");
                Console.WriteLine($"Fuel Tank: {fuelTank}");
           }
        }
       static void Main(string[] args)
       {
            Car myCar = new Car("BMW", "i8", "629MJR", "White");
            while (myCar.FuelTank > 0)
            {
                myCar.Drive();
            }

            myCar.ShowCarData();
       }
    }
    
}
