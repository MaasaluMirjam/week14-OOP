using System;

namespace OOPPet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;

            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratulations! You have adopted {name}!");
            }

            public double Weight
            {
                get { return weight; }
            }        

            public void ShowPetData() 
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }

            public void Eat()
            {
                Console.WriteLine("NomNomNom");
                weight += 0.2;
            }

            public void Run()
            {
                Console.WriteLine("Spin-Spin-Spin");
                weight -= 0.1;
            }

            public void GetOlder()
            {
                age++;
            }
          
        }

        static void Main(string[] args)
        {
           Pet myPet = new Pet("Hamster");
           myPet.ShowPetData();

            for(int i = 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($"Current weight: {myPet.Weight}");
                while(myPet.Weight > 0.7)
                {
                    myPet.Run();
                }
                /*if(myPet.Weight > 0.7)
                {
                    myPet.Run();                    
                }*/

                myPet.GetOlder();
            }
            myPet.ShowPetData();
        }
    }
}
