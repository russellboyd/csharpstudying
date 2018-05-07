﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualValueTypes
{
    public struct Food
    {
        private string _name;
        public string Name { get { return _name; } }

        public Food(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return _name;
        }

        public static bool operator ==(Food x, Food y)
        {
            
        }
    }
}
