﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            short age = 27;
            char sex = 'f';
            long personalId = 8306112507;
            int number = 27563571;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Personal ID: {personalId}");
            Console.WriteLine($"Unique Employee number: {number}");

        }
    }
}
