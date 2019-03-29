using System;
using System.Collections.Generic;

namespace wizards
{
    public interface IFighter
    {
        string name { get; set; }
        int strength  { get; set; }
        int health  { get; set; }
        int Attack(IFighter target);
    }
}