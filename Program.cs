﻿// See https://aka.ms/new-console-template for more information
string User;
int userGuess = 0;
bool pRepeat;

Startup();
RunGame();
Restart();






void Startup()
{
    Console.WriteLine("Please input user name");
    User = Console.ReadLine();
    Console.WriteLine("Hello, World!");
    Console.WriteLine("greetings " + User + "! (Yabadabadoo");
    return;
}


void Restart()
{

    //pRepeat ? RunGame() : Console.WriteLine("No worries thank you!");
    //pRepeat = true ? RunGame() : Console.WriteLine("No worries thank you!");

    if (pRepeat)
    {
        RunGame();
    }
    else
    {
        Console.WriteLine("No worries thank you!");
    }
}

void RunGame()
{
    Console.WriteLine("Guess what number I am thinking of between 0 and 10.");
    userGuess = Convert.ToInt32(Console.ReadLine());
    int compVar = RNG();
    Console.WriteLine((userGuess == compVar) ? "Nice! Good at guessing I guess" : "Dang, youre not so good at thinking I guess \n" + "You were " + Math.Abs(compVar - userGuess) + " off");
    Console.WriteLine("Do you want to try again? Yes or no (0 or 1)");
    pRepeat = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
    return;
}

int RNG()
{
    Random random = new Random();
    int retValue = random.Next(0, 10);
    return retValue;
}
