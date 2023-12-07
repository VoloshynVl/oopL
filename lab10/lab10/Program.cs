        CharSet set1 = new CharSet();
        CharSet set2 = new CharSet();

        set1.Add('a');
        set1.Add('b');
        set1.Add('c');

        set2.Add('b');
        set2.Add('c');

        Console.WriteLine("Set 1:");
        set1.Print();

        Console.WriteLine("Set 2:");
        set2.Print();

        Console.WriteLine("Removing 'a' from Set 1:");
        set1 = set1 - 'a';
        set1.Print();

        Console.WriteLine("Set 2 is subset of Set 1: " + (set2 > set1));

        Console.WriteLine("Set 1 is not equal to Set 2: " + (set1 != set2));