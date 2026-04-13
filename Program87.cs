using System;
using System.Text.RegularExpressions;
class Program {
    static void Main(){
        string email=""test@mail.com"";
        bool valid=Regex.IsMatch(email,@"^[^@\s]+@[^@\s]+\.[^@\s]+$"");
        Console.WriteLine(valid);
    }
}
