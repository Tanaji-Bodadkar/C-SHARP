using System;
using System.Text.RegularExpressions;
class Program {
    static void Main(){
        string s=""12345"";
        Console.WriteLine(Regex.IsMatch(s,""^\d+$""));
    }
}
