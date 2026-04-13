using System;
class Program {
    static void Main() {
        string s="hello";
        int c=0;
        foreach(char ch in s)
            if("aeiouAEIOU".Contains(ch)) c++;
        Console.WriteLine(c);
    }
}
