﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
	private string _lastname;
	internal string LastName
	{
		get {return _lastName;}
		set {_lastName = value;}  
	}

	public string FirstName {get; set;}

 	public string EmailAddress {get; set;}

 	public int CustomerId {get; private set;}

	public string FullName
	{
		get
		{
			return LastName + "," + FirstName;
		}
	}
	
    }
}
