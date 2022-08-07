// Написать программу, которая из имеющегося массива строк формирует массив, длина которых меньше либо равна 3 символа

string[] array(string[] arr)
{
    string[] array1 = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array1[j] = arr[i];
            j++;
        }
    }
    return array1;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + "  ");
    }
}

Console.WriteLine("Задайте длину массива");
int num = Convert.ToInt32(Console.ReadLine());
string[] newarray = new string[num];
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите {i + 1} элемент массива ");
    newarray[i] = Console.ReadLine();
}

Console.WriteLine("Массив элементов длина которых <=3:");
PrintArray(array(newarray));