namespace DiceGame { 
internal class Dice
{
  
    private static void Main(string[] args)
    {
        Dice_Roll1 dr = new Dice_Roll1();
        System.Console.WriteLine("Welcome! Please enter the amount of times you would like to roll the dice:");
        string numOfRolls = System.Console.ReadLine();
        dr.Rolls(numOfRolls);
    }
}
}



