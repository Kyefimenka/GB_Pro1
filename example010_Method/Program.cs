int [] array = {1, 12, 34, 45, 32, 21, 43, 45};
int n = array.Length;
int find = 45;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}