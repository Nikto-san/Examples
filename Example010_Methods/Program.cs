int[] array = {31, 72, 39, 81, 85, 66, 27, 81};

int n = array.Length;
int find = 81;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}