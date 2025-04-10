﻿using System;
using System.Runtime.CompilerServices;

namespace GameUnit
{
    public class Program
    {
        private static void Main()
        {

            MilitaryUnit a = new MilitaryUnit(10, 15, 20);
            SettlerUnit b = new SettlerUnit();

            b.Move(2);
            a.Move(3);

            Console.WriteLine($"The millitary unit has {a.Health} health and costs {a.Cost}");
            Console.WriteLine($"The settler unit has {b.Health} health and costs {b.Cost}");

        }
    }
}