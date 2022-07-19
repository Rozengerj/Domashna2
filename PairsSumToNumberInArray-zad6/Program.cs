int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int reqNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < input.Length; i++)
{
    for (int j = i; j < input.Length; j++)
    {
        if (input[i]+input[j]==reqNumber)
        {
            Console.WriteLine(input[i]+" " +input[j]);
        }
    }
}