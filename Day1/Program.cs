using System.Numerics;
using System.Text.RegularExpressions;



//string[] inputArr = {"1abc2","pqr3stu8vwx","a1b2c3d4e5f","treb7uchet"};
string[] inputArr = File.ReadAllLines(@"C:\Users\yanick\RiderProjects\AdventOfCode2023\Day1\input.txt");
int total = 0;

//get the positive numbers out of a string
Regex re = new Regex(@"\d");

//loop over the input array
foreach (var i in inputArr)
{
    //check the string of it contains numbers and store them in een collection
    MatchCollection m = re.Matches(i);
    var number = int.Parse(m[0].ToString() + m[m.Count - 1]);//creating the two digit number 
    Console.WriteLine(number);
    total += number;
}

Console.WriteLine(total);


