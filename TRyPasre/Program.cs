
// init
string readthis;

﻿Console.WriteLine("This is a new program that will \npredict the number you type in.");
readthis = Console.ReadLine();

// Tryparse
while (!int.TryParse(readthis, out int value))
{
    Console.WriteLine("Are you making fun of me? huh? \ntry again and put down a number. \njerk");
    readthis = Console.ReadLine();
}

// success
Console.WriteLine($"{readthis}, cool huh? yeah i know. im awesome..\n\n\nheh..");
Console.ReadLine();