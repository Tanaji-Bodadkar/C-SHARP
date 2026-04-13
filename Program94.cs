using System;
using System.Linq;
class Program{
    static void Main(){
        int[] a={1,2,3};
        int[] b={2,3,4};
        var c=a.Intersect(b);
        foreach(var i in c)
            Console.Write(i+"" "");
    }
}
