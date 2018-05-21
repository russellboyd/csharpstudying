using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    public struct Food
    {
        private string _name;
        FoodGroup _group;
        public string name { get { return _name; } }
        public FoodGroup Group{get {return _group; } }
        public Food(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public override string ToString()
        {
            return string.Format("{0}, ({1})", _name, _group);
        }

        public override bool ==(Food x, Food y)
        {
            return (x == y);
        }

    }
}