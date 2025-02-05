using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment01
{
    internal struct Person
    {
        #region Properties
        public int Age { get; set; }
        public string Name{ get; set; }

        #endregion

        #region Ctor
        public Person(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        #endregion

        #region Methods

        public void AddPerson()
        {
            int age;
            bool a;

            do
            {
                Console.Write("Enter Person`s Age: ");
                a = int.TryParse(Console.ReadLine(), out age);

                Console.Write("Enter Person`s Name: ");
                this.Name = Console.ReadLine();

                if (a)
                {
                    this.Age = age;
                    return;
                }
                Console.WriteLine("Invalid input! Please enter integer for Age.");
            }
            while (true);
            


        }

        public override string ToString()
        {
            return $"[Age: {this.Age}, Name: {this.Name}]";
        }

        #endregion
    }
}
