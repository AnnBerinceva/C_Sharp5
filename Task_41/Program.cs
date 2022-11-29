Console.Write("Значения через запятую ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"значений больше нуля = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int a = 0; a < input.Length; a++)
    {
        if (input[a] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int a = 0; a < input.Length; a++)
    {
        string temp = "";

        while (input [a] != ',')
        {
        if(a != input.Length - 1)
        {
            temp += input [a].ToString();
            a++;
        }
        else
        {
            temp += input [a].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int a = 0; a < array.Length; a++)
    {
        Console.Write(array[a] + " ");
    }
    Console.Write("]");
}