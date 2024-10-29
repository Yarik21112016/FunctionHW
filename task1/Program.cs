
int[] CreateArrayThreeDigit(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}.");
        }
    }
    Console.Write("]");
}

int CountEvenNums(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i]))
        {
            count++;
        }
    }

    return count;
}

bool IsEven(int num)
{
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) return true;
    }
    return false;
}


int[] arri = CreateArrayThreeDigit(6);
PrintArray(arri);

int CountEven = CountEvenNums(arri);
Console.Write($" => {CountEven}");