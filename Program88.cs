using System;
using System.Linq;
class Program {
    static void Main(){
        string p=""Tanaji123"";
        bool strong=p.Length>=8 && p.Any(char.IsUpper) && p.Any(char.IsDigit);
        Console.WriteLine(strong);
    }
}
