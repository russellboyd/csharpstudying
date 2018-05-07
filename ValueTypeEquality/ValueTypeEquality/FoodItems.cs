using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquality
{
    class FoodItems
    {
    }

    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets}
    public struct FoodItems : IEquatable<FoodItems>
    {
        public static bool operator ==(FoodItems lhs, FoodItems rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FoodItems lhs, FoodItems rhs)
        {
            return !lhs.Equals(rhs);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _group.GetHashCode();
        }

        public bool Equals(FoodItems other)
        {
            return this._name == other.Name && this._group == other._group;
        }

        public override bool Equals(object obj)
        {
            if (obj is FoodItems)
            {
                return Equals((FoodItems)obj);
            }
            else
            {
                return false;
            }
        }

        private readonly string _name;
        private readonly FoodGroup _group;
        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        public FoodItems(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
