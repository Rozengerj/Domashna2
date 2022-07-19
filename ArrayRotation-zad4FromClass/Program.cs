int[] Array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int rotationAmount = int.Parse(Console.ReadLine());
for (int i = 0; i < rotationAmount; i++)
{
    int currNumberBuffer = Array[0];
    for (int j = 0; j < Array.Length; j++)
    {
        int k = j + 1;
        if (k >= Array.Length)
        {
            k = 0;
        }
        int nextNumberBuffer = Array[k];
        Array[k] = currNumberBuffer;
        currNumberBuffer = nextNumberBuffer;
    }
}
for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}