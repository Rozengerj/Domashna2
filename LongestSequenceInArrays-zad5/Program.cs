int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int index = 0;
int numHolder = 0;
for (int i = 0; i < input.Length; i++)
{
    int tempIndex=1;
    for (int j = i; j < input.Length; j++)
    {
        int k = j + 1;
        if (k >= input.Length)
        {
            k = input.Length - 1;
        }
        if (input[j] != input[k])
        {
            break;
        }
        tempIndex++;
        
    }
    if(tempIndex >= index)
    {
        index = tempIndex;
        numHolder = i;
    }
    
}
for (int i = 0; i < index; i++)
{
    Console.Write(input[numHolder]+" ");
}