﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquals
{
    public struct Food
    {
        private string _name;
        public string name { get { return _name; } }

        public Food(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
