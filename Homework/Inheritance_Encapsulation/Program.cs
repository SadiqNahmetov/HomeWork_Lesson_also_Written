using System;
using System.Reflection;
using Domain.Models;
using Inheritance_Encapsulation.Data;

namespace Inheritance_Encapsulation
{
    class Program
    {
        private static object animal;

        static void Main(string[] args)
        {
            //Person person = new Person(55, "Sadiq",30);
            //person.name = "Sadiq";
            //person.age = 20;

            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "Nahmetov");
            //var personsurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Console.WriteLine(person.age + " "+ person.name);

            //Car car = new Car();
            //car.HorsePower = 120;

            //Console.WriteLine(car.HorsePower);

            //Animal animal = new Animal();

            //Context context = new Context();  

            Book book = new Book();

           

        }
    }
}
