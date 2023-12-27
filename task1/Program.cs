using System.Collections.Generic;
List<int> numbers = new List<int>();
int sum = 0;
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
numbers.Add(8);
numbers.Add(9);
numbers.Add(10);
foreach (int item in numbers)
{
    sum += item;
}

System.Console.WriteLine("The sum of all the elements in the list is: " + sum);