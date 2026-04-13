using System;
using System.Linq;
class Program{
    static void Main(){
        int[] arr={1,2,2,3};
        var d=arr.GroupBy(x=>x).Where(g=>g.Count()>1).Select(g=>g.Key);
        foreach(var i in d)
            Console.Write(i+"" "");
    }
}
