using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblems
{
    /// <summary>
    /// Simple Coustomer Class With Properties, Methods And Constructors
    /// </summary>
    public class Customer
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        //parametrized Constructor
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        // Default Constructor
        public Customer()
        {
            this.Id = 20;
            this.Name = string.Empty;
        }
        //Method to Print Id
        public void PrintId()
        {
            this.Id = 22;
            Console.WriteLine("Id is : {0}", this.Id);
        }
        //Method to Print Name
        public void PrintName()
        {
            this.Name = "Niraj";
            Console.WriteLine("Name is : {0}", this.Name);
        }

    }
}
