int[] array = new int[8];
//Random rnd = new Random();

Console.Write("{");
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-20,20);
    Console.Write(" " + array[i]+ " ");
}
Console.WriteLine("}");