using System;

namespace TheRabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit myRabbit = new Rabbit(Eyes.Black,Fur.Grey,Gender.Female, new DateTime(2010, 7, 29));

            //Runnig the things

            Console.WriteLine(myRabbit.RabbitDescription());
            Console.WriteLine(myRabbit.AgeInfo());
            Console.WriteLine(myRabbit.RunOrMove());
            Console.WriteLine(myRabbit.Sleep());
            Console.WriteLine(myRabbit.Eat());

            

        }
    }
}
