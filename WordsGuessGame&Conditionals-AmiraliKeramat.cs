string guess = "C#";
string input;
int attempts = 0;

bool correction = false;

while (!correction)
{ 
Console.WriteLine("Please enter your guess:");
    input = Console.ReadLine();
    if (input == guess)
    {
        Console.WriteLine("Congratulations! You guessed the correct phrase.");
        Console.WriteLine($"It took you {attempts + 1} attempts to guess the phrase.");
        correction = true;
        break;
    }
    else
    {
        Console.WriteLine("Incorrect guess. Please try again.");
        attempts++;
    }
}
Console.ReadKey(); //
