using System;
using System.Collections.Generic;
using System.Linq;


//Phase 1
// Console.WriteLine("What is the secret number??");
// string inputNumber = Console.ReadLine();
// Console.WriteLine($"You entered {inputNumber}.");

//Phase 2
// Console.WriteLine("What is the secret number??");
// string inputNumber = Console.ReadLine();
// string secretNumber = inputNumber;

// if (secretNumber != "42") 
// {
//     Console.WriteLine("ANHHH, you guessed wrong!");
// }
// else 
// {
//     Console.WriteLine("Correct!");
// }

//Phase 3
// Console.WriteLine("What is the secret number??");
// string inputNumber = Console.ReadLine();
// string secretNumber = inputNumber;

// List<string> numberOfGuesses = new List<string>();

// while (numberOfGuesses.Count < 3)
// {
//     if (secretNumber != "42")
//     {
//         numberOfGuesses.Add(inputNumber); //added "Guess again, please." 4 times
//         Console.WriteLine("Guess again, please.");
//         Console.ReadLine(); //allowed me to see the above writeline once and add another input!
//     }
//     else (secretNumber == "42")
//     {
//         Console.WriteLine("YOU GUESSED IT!");
//     }
// }

//Phase 4
Console.WriteLine("What is the secret number??");
int inputNumber = Convert.ToInt32(Console.ReadLine());

List<int> numberOfGuesses = new List<int>();


while (numberOfGuesses.Count < 3)
{
    int secretNumber = new Random().Next(0, 100);
    if (secretNumber != inputNumber)
    {
        numberOfGuesses.Add(inputNumber); //added first: "Guess again, please." 4 times
        Console.WriteLine($"You have guessed {numberOfGuesses.Count +1} times. Guess again, please.");
        Console.ReadLine(); //added 2nd: allowed me to see the above writeline once and add another input!
    }
    else if (secretNumber == inputNumber)
    {
        Console.WriteLine("YOU GUESSED IT!");
        break;
    }
}
    
