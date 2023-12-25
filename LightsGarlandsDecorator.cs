using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern;

public class LightsGarlandsDecorator : ILightsGarlandsDecorator
{
    private readonly IChristmasTree _tree;

    public LightsGarlandsDecorator(IChristmasTree tree)
    {
        _tree = tree;
    }

    public void Decorate()
    {
        _tree.Decorate();
        Console.WriteLine("Twinkling lights added to the tree!");
        Console.WriteLine("Glamorous garlands added to the tree!");
    }
}
