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
     
        public enum Eyes
        {
            Blue,
            Red,
            Black
        }

        public enum Fur
        {
            White,
            Brown,
            Black,
            Grey
        }

        public enum Gender
        {
            Male,
            Female
        }
        public class Rabbit
        {
            Eyes eyes;
            Fur fur;
            Gender gender;

            public Eyes Eyes
            {
                get { return this.eyes; }
                set { this.eyes = value; }
            }

            public Fur Fur
            {
                get { return this.fur; }
                set { this.fur = value; }
            }
            public Gender Gender
            {
                get { return this.gender; }
                set { this.gender = value; }
            }
            private DateTime birthDate;
            public DateTime BirthDate
            {
            get { return this.birthDate; }
            set { this.birthDate = value; }
            }

        public Rabbit(Eyes eyes, Fur fur, Gender gender, DateTime birthDate) 
        {
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
            this.birthDate = birthDate;
        }

        public int Age
        {
            get
            {
                DateTime currentDate = DateTime.Today;
                int age = currentDate.Year - BirthDate.Year;

                if (currentDate.Month < BirthDate.Month || (currentDate.Month == BirthDate.Month && currentDate.Day < BirthDate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public string RabbitDescription()
        {
            return $"I'm a verry cute {Gender} rabbit. My eyes are {Eyes}, my fur is clean and {Fur} and i am {Age} years old";
        }

        public string AgeInfo()
        {
            return $"I'm a {(Age).ToString()} years old {Gender} RaBBiT .";
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
