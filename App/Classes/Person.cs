﻿using System;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        }
    }
}