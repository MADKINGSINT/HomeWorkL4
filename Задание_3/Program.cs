int[] GetMassiv ()
{
Random rnd = new Random();
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
     array[i] = rnd.Next(0, 10);
}
Console.WriteLine(array);
return array;
}
int[] arr = GetMassiv();
void printArray(int[]array)
{
    for  (int i = 0; i<array.Length; i++  )
    {
        System.Console.Write($"{array[i]}\t");
    }
}

printArray(arr);
Console.WriteLine("");


