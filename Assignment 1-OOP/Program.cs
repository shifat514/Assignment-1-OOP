// See https://aka.ms/new-console-template for more information
using System;


namespace assignment1
{
    static class Program
    {


        public static void Main()
        {
            //normal class object example
            Console.WriteLine("Normal Class Object Example: ");
            Car car = new Car();
            car.Start();
            car.Drive();
            car.Stop();

            //Encapsulation
            Console.WriteLine("Encapsulation: " + Encapsulation.multiplyandAdd(4, 2));


            //Abstraction
            Console.WriteLine("Abstraction:");
            B b = new B();
            b.a1();
            b.a2();

            //Inheritence
            class2 obj = new class2();
            obj.Print();


            //Polymorphism
            Console.WriteLine("Polymorphism:");
            MyName name = new MyName();
            name.PrintFullName();
            Address address = new Address();
            address.PrintFullName();

        }

        public class Car
        {

            public void Start()
            {
                Console.WriteLine("Car Started");
            }

            public void Drive()
            {
                Console.WriteLine("Car is driving");
            }

            public void Stop()
            {
                Console.WriteLine("Car stopped");
            }


        }

        //Encapsulation

        static class Encapsulation
        {
            private static int number1 = 4;
            private static int number2 = 5;

            public static int multiplyandAdd(int num1, int num2)
            {
                return num1 * num2 + number1 + number2;
            }


        }
        //Abstraction
        public abstract class A
        {
            public abstract void a1();
            public void a2()
            {
                Console.WriteLine("a2");
            }
        }

        class B : A
        {
            public override void a1()
            {
                Console.WriteLine("a1 is overridden");
            }
        }

        //Inheritence
        public class Inheritence
        {
            public class class1
            {
                public void Print()
                {
                    Console.WriteLine("Inheritence: Hello from class1");

                }
            }

        }
        //Polymorphism
        public class Polymorphism
        {
            public class Name
            {
                public string FirstName = "Shifat";
                public string LastName = "Habib";

                public void PrintFullName()
                {
                    Console.WriteLine(FirstName + " " + LastName);

                }
            }
        }
    }
}