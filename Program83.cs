using System;
class Program {
    static void Main(){
        string s=""Hello World Tanaji"";
        string[] words=s.Split(' ');
        foreach(string w in words)
            Console.WriteLine(w);
    }
}
