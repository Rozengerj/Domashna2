int ordersCount = int.Parse(Console.ReadLine());
float total = 0;
float[] pricesForOrders = new float[ordersCount];
for(int i = 0; i < ordersCount; i++)
{
    float capsulePrice = float.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());
    pricesForOrders[i] = ((days * capsuleCount) * capsulePrice);
    total += (days * capsuleCount) * capsulePrice;
}
for (int j = 0; j < ordersCount; j++)
{
    Console.WriteLine("The price for the coffee is: $" + pricesForOrders[j]);
}
Console.WriteLine("Total: $"+total);