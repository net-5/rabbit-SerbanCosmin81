using System;

namespace TheRabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit myRabbit = new Rabbit(); // creating an instance of the Class 

            Console.WriteLine("Enter the color of the eyes: ");

            myRabbit.Eyes = Console.ReadLine();

            Console.WriteLine("Enter the color of the fur: ");

            myRabbit.Fur = Console.ReadLine();

            Console.WriteLine("Enter the gender: ");

            myRabbit.Gender = Console.ReadLine();

            Console.WriteLine("Enter the birthdate: ");

            myRabbit.BirthDate = Convert.ToInt16( Console.ReadLine()); // int.Parse(Console.ReadLine());

            //Runnig the things

            Console.WriteLine(myRabbit.RabbitDescription());
            Console.WriteLine(myRabbit.AgeInfo());
            Console.WriteLine(myRabbit.RunOrMove());
            Console.WriteLine(myRabbit.Sleep());
            Console.WriteLine(myRabbit.Eat());

            

        }
    }
}
