﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new PrimeMinistersByYearDictionary()
            {
                new PrimeMinister("James Callaghan", 1974) ,
                new PrimeMinister("Margaret Thatcher", 1979) ,
                new PrimeMinister("Tony Blair", 1997)
            };

            primeMinisters.Add(new PrimeMinister("John Major", 1990));

            Console.WriteLine("Tony is " + primeMinisters[1997]);

            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm);
            }
        }

        class PrimeMinistersByYearDictionary : KeyedCollection<int, PrimeMinister>
        {
            protected override int GetKeyForItem(PrimeMinister item)
            {
                return item.YearElected;
            }

            override 
        }
    }
}