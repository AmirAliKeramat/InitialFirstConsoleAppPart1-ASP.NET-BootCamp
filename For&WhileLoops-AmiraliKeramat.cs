byte ShouldGuess = 7;
byte input ;

Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("You have 5 tries to guess the number between 1 and 10.");
bool Guess = false;


while (!Guess)
{
    for (int attempts = 0; attempts < 5; attempts++)
    {
        Console.WriteLine("Guess A number :");
        input = Convert.ToByte(Console.ReadLine());

        if (input == ShouldGuess)
        { 
        Console.WriteLine("Congratulations! You guessed the number!");
            Guess = true;
            break;
        }
        else
        {
            Console.WriteLine("Wrong guess! Try again.");
            Console.WriteLine($"Wrong guess! You have {5 - attempts} tries left.");
            
        }
                

    }
    if (!Guess)
    {
        Console.WriteLine("Sorry, you've used all your tries. The number was " + ShouldGuess + ".");
    }
    break; // Exit the loop after 5 attempts
}
    
    
 

Console.ReadKey();