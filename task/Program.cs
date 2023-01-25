Console.Write("Введите значения через запятую: ");
string[] array = Console.ReadLine().Split(',');
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;    
    }
}
string[] result = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[j] = array[i];
        j++;
           
    }
}
Console.WriteLine(string.Join(", ", result));