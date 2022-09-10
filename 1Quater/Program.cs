Console.Clear();

string[] arrayFormed =  {"Task", "Hi", "distance", "privet", "thi", "-333", "s", "1989",
                        "my_sun", "is", "abcd", "Greece", "my", "fw", "China", "Belarus"};

int count = CountStringLessThreeChar(arrayFormed);
string[] resultArray =  FillResultArray(arrayFormed,count);

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int CountStringLessThreeChar(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] FillResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

PrintArray(resultArray);