public class Program
{
    public static void Main()
    {
        const string MenuString = "Choose the exercise\nEx2(1)\nEx3(2)\nEx4(3)";
        const string InvalidNumber = "Invalid number, try again";
        int userNum = 0;
        bool validNumber = true;
        Console.WriteLine(MenuString);
        try
        {
            userNum = int.Parse(Console.ReadLine());
            validNumber = true;
        }
        catch (Exception)
        {
            Console.WriteLine(InvalidNumber);
            validNumber = false;
        }

        switch (userNum)
        {
            case 1:
                const string LiveDownMsg = "You got hit by a trap! You lose one live, and go to ";
                const string CoinMsg = "You got a coin and now have ";
                const string YouLose = "You lose the game";
                const string YouWin = "You got all five coins! You win!";
                int coins = 0;
                int lives = 3;
                Random trap = new Random();
                while (lives > 0 && coins < 5)
                {
                    if (trap.Next(1, 101) > 30)
                    {
                        coins++;
                        Console.WriteLine(CoinMsg + coins);
                    }
                    else
                    {
                        lives--;
                        Console.WriteLine(LiveDownMsg + lives);
                    }
                    if(lives == 0)
                    {
                        Console.WriteLine(YouLose);
                    }
                    else if (coins == 5)
                    {
                        Console.WriteLine(YouWin);
                    }
                }
                break;
            case 2:
                const string IntroMsg = "Enter a number to know its divisors. 0 To exit.";
                const string DivMsg = "{0}'s divisors are {1}";
                //string trace = "i és {0}";
                string numberString = "";
                int numDivide = 0;
                do
                {
                    Console.WriteLine(IntroMsg);
                    do
                    {
                        try
                        {
                            numDivide = int.Parse(Console.ReadLine());
                            validNumber = true;
                        }
                        catch(Exception) 
                        {
                            Console.WriteLine(InvalidNumber);
                            validNumber = false;
                        }
                        

                    } while (!validNumber);
                    if (numDivide != 0)
                    {
                        for (int i = 1; i<=numDivide; i++)
                        {
                            //Console.WriteLine(trace, i);
                            if(numDivide%i == 0)
                            {
                                numberString += i + " ";
                            }
                        }
                        Console.WriteLine(DivMsg, numDivide, numberString);
                    }
                    
                    numberString = "";
                }while(numDivide > 0);
                break;
            case 3:
                const string InputMsg = "Introduce the secret number for the level";
                const string DoorNumMsg = "{0} doors were generated";
                string openDoorMsg = "You can open doors number: ";
                int secretNum = 0;
                Console.WriteLine(InputMsg);
                Random doorNumRand = new Random();
                int doornum;
                try
                {
                    secretNum = int.Parse(Console.ReadLine());
                    validNumber = true;
                }
                catch (Exception)
                {
                    Console.WriteLine(InvalidNumber);
                    validNumber = false;
                }
                doornum = doorNumRand.Next(5, 16);
                Console.WriteLine(DoorNumMsg, doornum);
                for (int i = secretNum; i < doornum; i++)
                {
                    if(i % secretNum == 0)
                    {
                        openDoorMsg += i + " ";
                    }
                }
                Console.WriteLine(openDoorMsg);
                break;
            default:
                break;
        }
    }
}