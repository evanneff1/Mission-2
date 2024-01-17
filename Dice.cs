

internal class Dice
{
  
    private static void Main(string[] args)
    {
        Dice_Roll dr = new Dice_Roll();
        System.Console.WriteLine("Welcome! Please enter the amount of times you would like to roll the dice:");
        string numOfRolls = System.Console.ReadLine();
        dr.Rolls(numOfRolls);
    }
}


internal class Dice_Roll
{
    public void Rolls(string s)
    {
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls: ", s);

        int numOfRolls = int.Parse(s);

        System.Random rnd = new System.Random();
        int[] rollArray = new int[12];
        for (int i = 0; i < numOfRolls; i++) 
        {
            
            int randomNumber = rnd.Next(2, 13);
            if (randomNumber == 2) { rollArray[0] += 1; }
            if (randomNumber == 3) { rollArray[1] += 1; }
            if (randomNumber == 4) { rollArray[2] += 1; }
            if (randomNumber == 5) { rollArray[3] += 1; }
            if (randomNumber == 6) { rollArray[4] += 1; }
            if (randomNumber == 7) { rollArray[5] += 1; }
            if (randomNumber == 8) { rollArray[6] += 1; }
            if (randomNumber == 9) { rollArray[7] += 1; }
            if(randomNumber == 10) { rollArray[8] += 1; }
            if (randomNumber == 11) { rollArray[9] += 1; }
            if (randomNumber == 12) { rollArray[10] += 1; }
       
        }

        int onePercentOfRolls = numOfRolls / 100;

        onePercentOfRolls = onePercentOfRolls > 0 ? onePercentOfRolls : 1;

        SummingArrays(rollArray, onePercentOfRolls);
    }

    public void SummingArrays (int[] arrayToSum, int dividend)
    {

        for (int numOfRoll = 0; numOfRoll <= 10; numOfRoll++)
        {
            System.Console.Write((numOfRoll+2) + ": ");
            int percentage = arrayToSum[numOfRoll] / dividend; // 1% of 1000 is 10

            for (int numOfStars = 0; numOfStars < percentage; numOfStars++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine();
        }
    }

    }


