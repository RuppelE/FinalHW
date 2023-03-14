int CountString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] ResultArray(string[] array, int count)
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

void PrintArray(string[] array) 
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

string[] array =  {"hello", "2", "world", ":-)"};
System.Console.WriteLine("Исходны массив:");
PrintArray(array);
System.Console.WriteLine("Далее из имеющегося массива строк формирем массив из строк, длина которых меньше либо равна трём символам");
int countFirst = CountString(array);
string[] result =  ResultArray(array,countFirst);
PrintArray(result);