<<<<<<< HEAD
﻿using Dal;
using System;

namespace Logic
{
    public class Employee : IEmployee
    {
        public int Id { get; }
        public string Name { get; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //DI voor dal
        private readonly IEmployeeDal EmpolyeDal;
        public Employee(IEmployeeDal empolyeDal)
        {
            EmpolyeDal = empolyeDal;
        }

        public Employee() { }

        //Methodes kunnen aanroepen met EmpolyeDal.Methode(). En ook alleen maar die in de Interface IEmployeDal staat.
    }
}
=======
﻿using Dal;
using System;

namespace Logic
{
    public class Employee : IEmployee
    {
        public int Id { get; }
        public string Name { get; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //DI voor dal
        private readonly IEmployeeDal EmpolyeDal;
        public Employee(IEmployeeDal empolyeDal)
        {
            EmpolyeDal = empolyeDal;
        }

        public Employee() { }

        //Methodes kunnen aanroepen met EmpolyeDal.Methode(). En ook alleen maar die in de Interface IEmployeDal staat.
    }
}
>>>>>>> main
