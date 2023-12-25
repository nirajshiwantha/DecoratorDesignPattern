using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern;

public class LightsDecorator : ILightsDecorator
{
    private readonly IChristmasTree _tree;

    public LightsDecorator(IChristmasTree tree)
    {
        _tree = tree;
    }

    public void Decorate()
    {
        _tree.Decorate();
        Console.WriteLine("Twinkling lights added to the tree");
    }
}
