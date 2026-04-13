using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        string s="hello";
        var d=new Dictionary<char,int>();
        foreach(char c in s){
            if(d.ContainsKey(c)) d[c]++;
            else d[c]=1;
        }
        foreach(var i in d)
            Console.WriteLine(i.Key+""+i.Value);
    }
}
