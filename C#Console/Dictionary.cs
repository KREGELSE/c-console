

class Dictionary1
{
    public static void Dict1(string[] args)
    {
        Dictionary1<string, string> phonebook = new Dictionary1<string, string>();
        phonebook.Add("Alice", "123-456-7890");
        phonebook.Add("Bob", "214-331-3345" );

        Console.WriteLine(phonebook["Alice"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        Inventory.Add("Apples", 50);
        Inventory.Add("Bananas", 30);
        Inventory.Add("Mango", 30);
        Inventory.Add("Grapes", 12);


        foreach(KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine(item,Key + ": " + item.Value);
        }

    }
}