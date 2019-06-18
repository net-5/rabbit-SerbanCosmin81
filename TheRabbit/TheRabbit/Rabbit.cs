using System;
using System.Collections.Generic;
using System.Text;

namespace TheRabbit
{
    //    Model the Rabbit class knowing that:

    //a rabbit can have Blue, Red or Black eyes
    //a rabbit's fur can be white, brown, black or grey
    //it has a gender
    //has a birth date, and based on that you should be able to see how old the rabbit is
    //we also know that a rabbit is a mammal that moves, sleeps and eats
    class Rabbit // we  create all in here
    {
        private string eyes;
        private string fur;
        public string Eyes
        {
            get { return eyes; }
            set
            {
                if (value == "Blue" || value == "Red" )
                {
                    eyes = value;
                }
                else
                {
                    eyes = "Black";
                };
            }
        }
        public string Fur
        {
            get {return fur ; }
            set
            {
                if (value == "White" || value == "Brown" || value == "Black")
                {
                    fur = value;
                }
                else
                {
                    fur = "Grey";
                }
             }
        }
        public string Gender { get; set; }
        public int BirthDate { get; set; }

        public string RabbitDescription()
        {
            return $"I'm a verry cute {Gender} rabbit. My eyes are {Eyes}, my fur is clean and {Fur} and i am {2019 - BirthDate} old";
        }

        public string AgeInfo()
        {
            return $"I'm a {(2019 - BirthDate).ToString()} years old {Gender} RaBBiT .";
        }

        public string RunOrMove()
        {
            return "I can run verry fast or i can move verry slow";
        }

        public string Sleep()
        {
            return "Sleeping for me is like being on alert 24/7";
        }

        public string Eat()
        {
            return "I eat carrots like BugsBunny and other green vegetables!!!";
        }


    }
}
