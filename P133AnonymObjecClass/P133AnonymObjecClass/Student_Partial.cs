using System;
using System.Collections.Generic;
using System.Text;

namespace P133AnonymObjecClass
{
    partial class Student
    {
        //Class Constructor
        //Classnan Eyni Adda Olur
        //Classdan Obyenct(instance) yaradilan ilk ise dusen methodur
        //Constructorun Return Type Olmur
        //Constructoru Cagirmaq Olmur Yalniz Instance Zamani Isdifade Olunur
        //Constructor Parametrde Qebul Edir
        public Student(string name)
        {
            Name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            SurName = surname;
        }

        public Student(string name, string surName, byte age) : this(name, surName)
        {
            Age = age;
        }

        public string GetFullName()
        {
            return $"Name: {Name}\nSurName: {SurName}";
        }

        public string GetFullInfo()
        {
            return $"{GetFullName()}\nAge: {Age}\n{Address.GetAddress()}";
        }
    }
}
