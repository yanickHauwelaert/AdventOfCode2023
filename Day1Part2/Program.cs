
using System.Text.RegularExpressions;


string[] inputArr = File.ReadAllLines(@"C:\Users\yanick\RiderProjects\AdventOfCode2023\Day1\input.txt");
//string[] inputArr = {"two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" };
int total = 0;
string pattern = @"one|two|three|four|five|six|seven|eight|nine|\d";

Regex re = new Regex(pattern);

foreach (var input in inputArr)
{
    MatchCollection m = re.Matches(input);

    var firstNumber = m.First().Value;
    var lastNumber = m.Last().Value;
    
    switch (firstNumber)
    {
        case "one":
            firstNumber = "1";
            break;
        case "two":
            firstNumber = "2";
            break;
        case "three":
            firstNumber = "3";
            break;
        case "four":
            firstNumber = "4";
            break;
        case "five":
            firstNumber = "5";
            break;
        case "six":
            firstNumber = "6";
            break;
        case "seven":
            firstNumber = "7";
            break;
        case "eight":
            firstNumber = "8";
            break; 
        case "nine":
            firstNumber = "9";
            break;
    }
    switch (lastNumber)
    {
        case "one":
            lastNumber = "1";
            break;
        case "two":
            lastNumber = "2";
            break;
        case "three":
            lastNumber = "3";
            break;
        case "four":
            lastNumber = "4";
            break;
        case "five":
            lastNumber = "5";
            break;
        case "six":
            lastNumber = "6";
            break;
        case "seven":
            lastNumber = "7";
            break;
        case "eight":
            lastNumber = "8";
            break; 
        case "nine":
            lastNumber = "9";
            break;
    }

    var number = int.Parse(firstNumber+lastNumber);
    Console.WriteLine(number);
    total += number;
}

Console.WriteLine(total);