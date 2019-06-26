using System;

namespace TheRabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit myRabbit = new Rabbit(Eyes.black,Fur.grey,Gender.female,2010);

            //Runnig the things

            Console.WriteLine(myRabbit.RabbitDescription());
            Console.WriteLine(myRabbit.AgeInfo());
            Console.WriteLine(myRabbit.RunOrMove());
            Console.WriteLine(myRabbit.Sleep());
            Console.WriteLine(myRabbit.Eat());

            

        }
    }
}
