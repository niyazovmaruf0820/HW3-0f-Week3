List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        int a = Convert.ToInt32(Console.ReadLine());
        int found = numbers.Find(x => x == a);
        if (found == a)
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");
        }