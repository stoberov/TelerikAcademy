using System;

internal class TestApp
{
    private static void Main()
    {
        BST<int, string> firstTree = new BST<int, string>();
        firstTree.Add(4, "4");
        firstTree.Add(12, "12");
        firstTree.Add(1, "1");
        firstTree.Add(8, "8");
        firstTree.Add(5, "5");

        foreach (var node in firstTree)
        {
            Console.WriteLine(string.Format("{0} {1}", node.Key, node.Value));
        }

        Console.WriteLine();

        firstTree.Remove(8);
        BST<int, string> secondTree = firstTree.Clone();

        Console.WriteLine(firstTree);
        Console.WriteLine(secondTree);

        BST<int, string> thirdTree = new BST<int, string>();
        thirdTree.Add(5, "10");
        Console.WriteLine(thirdTree);

        Console.WriteLine(firstTree.Equals(secondTree));
        Console.WriteLine(object.ReferenceEquals(firstTree, secondTree));
        Console.WriteLine(firstTree.Equals(thirdTree));
        Console.WriteLine(object.ReferenceEquals(firstTree, thirdTree));

        thirdTree.Add(8, "16");
        thirdTree.Add(1, "2");
        thirdTree.Add(12, "24");
        thirdTree.Add(4, "8");
        Console.WriteLine(thirdTree);

        Console.WriteLine(firstTree.Equals(thirdTree));
        Console.WriteLine(object.ReferenceEquals(firstTree, thirdTree));

        BST<int, string> fourthTree = new BST<int, string>();
        fourthTree.Add(1, "1");
        fourthTree.Add(1, "one");
        Console.WriteLine(fourthTree);
    }
}