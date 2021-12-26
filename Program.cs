
int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
   
    return array;
}
(int[], int[]) Dev2(int[] ArrayA)
{
    int[] ArrayB = new int[0];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i] > 8)
        {
            int lenght = ArrayB.Length;
            Array.Resize(ref ArrayB, lenght + 1);
            ArrayB[j] = ArrayA[i];
            j++;

        }

    }
    return (ArrayB, ArrayA); 
}
void WriteArray(int[] ArrayB, int[] ArrayA)

{
    Console.Write("[");
    for (int i = 0; i < ArrayA.Length; i++)
    {
        Console.Write(ArrayA[i]);
        if (i != ArrayA.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayB.Length; i++)
    {
        Console.Write(ArrayB[i]);
        if (i != ArrayB.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
WriteArray(Dev2(FillArray());
