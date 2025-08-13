// See https://aka.ms/new-console-template for more information
int Input;
Console.WriteLine("Enter a number more than 1 :");
Input = Convert.ToInt32(Console.ReadLine());
int output = 0;

    

while ( Input <=1)
{
    Console.WriteLine("Please Enter a Number Higher than 1 :");
    Input = Convert.ToInt32(Console.ReadLine());

}


    for (int i = 1; i <= Input; i+=2)
    {
        output = output + i;
        Console.WriteLine(output);

    }


Console.ReadKey();