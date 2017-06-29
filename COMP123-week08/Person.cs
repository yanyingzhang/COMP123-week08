﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_week08
{
    /// <summary>
    /// This is the person class
    /// </summary>
    class Person
    {
        //private instance variables (fields)
        private string _name;
        private int _age;

        //public properites..................
        public string Name
        {
            get // access method
            {
                return this._name;
            }
            set // access method
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        //constructors.......................
        /// <summary>
        /// This is the constructor for the Person class
        /// It takes two arguments - name(string) and age(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //public methods.....................
        /// <summary>
        /// This method enables the person object to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name+" is talking");
        }
    }
}
