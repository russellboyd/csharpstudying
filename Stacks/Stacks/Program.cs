﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();
            books.Push("Programming WPF");
            books.Push("The Philosophy Book");
            books.Push("Heat and Thermodynamics");
            books.Push("Harry Potter and the Chamber of Secrets");

            Console.WriteLine("ALL BOOKS: ");
            foreach (string title in books)
            {
                Console.WriteLine(title);
            }
        }
    }
}
