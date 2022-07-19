int fieldSize = int.Parse(Console.ReadLine());
if (fieldSize < 0 || fieldSize > 1000)
{
    throw new ArgumentException("From 0 to 1000!");
}
int[] LadybugPos = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[] field = new int[fieldSize];
int CommandCount = 1;
bool newPosIsAvailable = true;
for (int i = 0; i < LadybugPos.Length; i++)
{
    field[LadybugPos[i]] = 1;
}
string[] Commands = Console.ReadLine().Split().ToArray();
while (Commands[0] != "end"||CommandCount>100)
{
    newPosIsAvailable = true;
    if (Commands[1] == "right")
    {
        if (field[int.Parse(Commands[0])] == 1)
        {
            int newPos = int.Parse(Commands[2]) + int.Parse(Commands[0]);
            if (newPos < field.Length)
            {
                while(field[newPos] == 1)
                {
                    newPos = newPos + int.Parse(Commands[2]);
                    if (newPos >= field.Length)
                    {
                        newPosIsAvailable = false;
                        break;                   
                    }
                }
                if(newPosIsAvailable == true)
                {
                    field[newPos] = 1;
                    field[int.Parse(Commands[0])] = 0;
                }
                else
                {
                    field[int.Parse(Commands[0])] = 0;
                }
            }
            else
            {
                field[int.Parse(Commands[0])] = 0;
            }

        }
    }
    if (Commands[1] == "left")
    {
        if (field[int.Parse(Commands[0])] == 1)
        {
            int newPos =int.Parse(Commands[0]) - int.Parse(Commands[2]);
            if (newPos > -1)
            {
                while (field[newPos] == 1)
                {
                    newPos = newPos - int.Parse(Commands[2]);
                    if (newPos >= -1)
                    {
                        newPosIsAvailable = false;
                        break;
                    }
                }
                if (newPosIsAvailable == true)
                {
                    field[newPos] = 1;
                    field[int.Parse(Commands[0])] = 0;
                }
                else
                {
                    field[int.Parse(Commands[0])] = 0;
                }
            }
            else
            {
                field[int.Parse(Commands[0])] = 0;
            }
        }
    }
    CommandCount++;
    Commands = Console.ReadLine().Split().ToArray();
}
for (int i = 0; i < fieldSize; i++)
{
    Console.Write(field[i]+" ");
}
if (CommandCount > 100)
{
    Console.WriteLine("You ran out of commands!");
}