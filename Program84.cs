using System;
using System.Linq;
class Program {
    static void Main(){
        string s1=""listen"",s2=""silent"";
        bool res=s1.OrderBy(c=>c).SequenceEqual(s2.OrderBy(c=>c));
        Console.WriteLine(res);
    }
}
