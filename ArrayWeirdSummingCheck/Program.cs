int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
bool leftWasEqualtoRight = false;
for (int i = 0; i < input.Length; i++)
{
    int totalRight = 0;
    int totalLeft = 0;
    for (int j = i+1; j < input.Length; j++)
    {
        totalRight += input[j]; 
    }
    for (int j = i-1; j > -1; j--)
    {
        totalLeft += input[j];
    }
    //Console.WriteLine(totalLeft);
    //Console.WriteLine(totalRight);
    if (totalLeft == totalRight)
    {
        Console.WriteLine(i);
        leftWasEqualtoRight = true;
    }
}
if (leftWasEqualtoRight == false)
{
    Console.WriteLine("no");
}