string[] CreateStringArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        int len = new Random().Next(1, 10);
        string str = "";
        for (int j = 0; j < len; j++)
            str = str + j;
        result[i] = str;
    }

    return result;
}

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}

int GetCutArrayLength(string[] array, int cutLength)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= cutLength)
            result++;
    }

    return result;
}

string[] CutStringArray(string[] array, int cutLength)
{
    int resultSize = GetCutArrayLength(array, cutLength);
    string[] resultArray = new string[resultSize];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= cutLength)
        {
            resultArray[j] = array[i];
            j++;
        }
    }

    return resultArray;
}


int size = new Random().Next(10, 20);
string[] srcArray = CreateStringArray(size);
Console.WriteLine("Source string array:");
PrintStringArray(srcArray);
string[] resultArray = CutStringArray(srcArray, 3);
Console.WriteLine();
Console.WriteLine("Result string array:");
PrintStringArray(resultArray);