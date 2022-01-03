

int[] CreateWholeNumbers(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int GetLength(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}


int[] CreateEvenNumbers(int[] array, int n)
{
    int[] newArray = new int[n];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            newArray[j] = array[i];
            j++;
        }
    
        
    }
    return newArray;
}

int[] wholeNumbersArray = CreateWholeNumbers(5);
PrintArray(wholeNumbersArray);
Console.WriteLine();
PrintArray(CreateEvenNumbers(wholeNumbersArray, GetLength(wholeNumbersArray)));