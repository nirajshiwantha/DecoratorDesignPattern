using DecoratorDesignPattern;

class Program
{
    static void Main()
    {

        IChristmasTree tree = new ChristmasTree();

        //tree = new LightsDecorator(tree);
        tree = new LightsGarlandsDecorator(tree);

        tree.Decorate();

    }
}
