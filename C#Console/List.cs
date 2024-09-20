
using System.Collections.Generic;
class Lists
{
    public static void List1(String[] args)
    {
        Lists<string> fruits = new List<string>();
        {
            Lisst<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            fruits.Remove("Banana");
            Fruits.Insert(0, "Pineapple");

            Console.WriteLine(fruits.Count);
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        }
    }
}