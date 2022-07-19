int lostGames = int.Parse(Console.ReadLine());
float headsetPrice = float.Parse(Console.ReadLine());
float mousePrice = float.Parse(Console.ReadLine());
float keyboardPrice = float.Parse(Console.ReadLine());
float displayPrice = float.Parse(Console.ReadLine());
float total = (lostGames/2*headsetPrice)+(lostGames/3*mousePrice)+(lostGames/6*keyboardPrice)+(lostGames/12*displayPrice);
Console.WriteLine("Rage expenses: " + total + " lv.");