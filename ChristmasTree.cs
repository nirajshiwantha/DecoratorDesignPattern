using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern;

public class ChristmasTree : IChristmasTree
{
    public void Decorate()
    {
        Console.WriteLine("A plain Christmas tree is here!");
    }
}
