using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Stat: IStat
    {
        public int Id { get; }
        public int Value { get; }
        public string Title { get; }

        public Stat(int id, string title, int value)
        {
            Id = id;
            Title = title;
            Value = value;
        }

        public IStat GetStatByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
