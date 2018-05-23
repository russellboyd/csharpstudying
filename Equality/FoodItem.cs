public enum FoodGroup {Meat, Fruit, Vegetables, Sweets}

public struct FoodItem : IEquatable<FoodItem>
{
	private readonly string _name;
	private readonly FoodGroup _group;

	public string Name{get{return _name;}}
	
	public FoodGroup Group{get{return _group;}}

	public FoodItem(string name, FoodGroup group)
	{
		this_name = name;
		this._group = group;
	}


	public override string ToString()
	{
		return _name;
	}

//equality implementation
#region equality implementation

public static bool opreator ==(FoodItem lhs, FoodItem rhs)
{
	return lhs.Equals(rhs);
}

public static bool operator !=(FoodItem lhs, FoodItem rhs)
{
	return !lhs.Equals(rhs);
}

public override int GetHashCode()
{
	return _name.GetHashCode() ^ _group.GetHashCode();
}

public bool Equals(FoodItem other)
{
	return this._name == other.Name && this._group == other._group;
}

public override bool Equals(object obj)
{
	
}
}	