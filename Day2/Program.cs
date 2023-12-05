/*
using System.Text.RegularExpressions;

var TestPath = @"C:\Users\yanick\RiderProjects\AdventOfCode2023\Day2\TestInput";
var RealPath = @"C:\Users\yanick\RiderProjects\AdventOfCode2023\Day2\inputDay2.txt";

var inputArr = File.ReadAllLines(TestPath);

Dictionary<string, int> maxCubes = new()
{
    { "red", 12 },
    { "green", 13 },
    { "blue", 14 }
};


for (var i = 0; i < inputArr.Length; i++)
{
   var gameSets = inputArr[i].Split(';');
}
*/

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
var TestPath = @"C:\Users\yanick\RiderProjects\AdventOfCode2023\Day2\TestInput";
var RealPath = @"C:\Users\yanick\RiderProjects\AdventOfCode2023\Day2\inputDay2.txt";
var inputArr = File.ReadAllLines(RealPath);
var total = 0;
foreach (var input in inputArr)
{
    total += (int)PartOne(input);
}

Console.WriteLine(total);

     object PartOne(string input) => (
        from line in input.Split("\n")
        let game = ParseGame(line)
        where game.red <= 12 && game.green <= 13 && game.blue <= 14
        select game.id
    ).Sum();

     object PartTwo(string input) => (
        from line in input.Split("\n")
        let game = ParseGame(line)
        select game.red * game.green * game.blue
    ).Sum();

    // no need to keep track of the individual rounds in a game, just return 
    // the maximum of the red, green, blue boxes
    Game ParseGame(string line) =>
        new Game(
            ParseInts(line, @"Game (\d+)").First(),
            ParseInts(line, @"(\d+) red").Max(),
            ParseInts(line, @"(\d+) green").Max(),
            ParseInts(line, @"(\d+) blue").Max()
        );

    // extracts integers from a string identified by a single regex group.
    IEnumerable<int> ParseInts(string st, string rx) =>
        from m in Regex.Matches(st, rx)
        select int.Parse(m.Groups[1].Value);



record Game(int id, int red, int green, int blue);