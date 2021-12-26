int[] array = new int[8];
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-20,20);
    Console.Write($" " " + array[i]+ " " ");
}
