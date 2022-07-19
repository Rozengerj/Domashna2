float budget = float.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
float lightsaberPrice = float.Parse(Console.ReadLine());
float robesPrice = float.Parse(Console.ReadLine());
float beltPrice = float.Parse(Console.ReadLine());
float total =(students * robesPrice + (students + ((students / 10)+1) ) * lightsaberPrice + ((students % 6) + ((students / 6) * 5)) * beltPrice);
if (total > budget)
{
    Console.WriteLine("John will need " + (total - budget) + " lv more.");
}
else
{
    Console.WriteLine("The money is enough, it will cost " + total + " lv.");
}