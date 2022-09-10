Console.Clear();

string[] arrayFormed =  {"Task", "Hi", "distance", "privet", "thi", "-333", "s", "1989",
                        "my_sun", "is", "abcd", "Greece", "my", "fw", "China", "Belarus"};

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }