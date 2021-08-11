using System;

namespace pickme
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Tree tree = new Tree();
            tree.AddNode(new ListItem("One"));
            tree.AddNode(new ListItem("Two"));
            tree.AddNode(new ListItem("Three"));
            tree.AddNode(new ListItem("Four"));
            tree.AddNode(new ListItem("Fives"));

            tree.PrintTree(tree.head);
        }
    }
}
