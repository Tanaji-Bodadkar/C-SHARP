using System;
using System.Linq;
class Program {
    static void Main() {
        string s="madam";
        string r=new string(s.Reverse().ToArray());
        Console.WriteLine(s==r?"Palindrome":"Not");
    }
}
