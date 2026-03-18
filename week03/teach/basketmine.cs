/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class ABasketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();
        using var reader = new TextFieldParser("C:\\Users\\RUKN AL BAB\\Desktop\\cse212-projects\\week03\\teach\\basketball.csv");
        //using var reader = new TextFieldParser(@"cse212-projects\\week03\\teach\\basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            if (players.ContainsKey(playerId)) {
                players[playerId] += points;
            } else {
                players[playerId] = points;
            }
        }

        //Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");
        var playersArray = players.ToArray();

        //Console.WriteLine($"Players Array: {{{string.Join(", ", playersArray)}}}");
        var x = new Dictionary<string, int>();
        foreach (var player in playersArray) {
            x[player.Key] = player.Value;
        }

        int n = 0;
        Console.WriteLine("TOP 10 Players");
        while ( n < 10) {
        int maxValue = x.Values.Max();
        foreach (var player in playersArray) {
            if (player.Value == maxValue) {
                Console.WriteLine($"Player {n + 1}: {player.Key} with {player.Value} points");
                x.Remove(player.Key);
                n++;
                break;
                
            }
        }}

        var topPlayers = new string[10];
    }
}