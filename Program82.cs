using System;
using System.Linq;
class Program {
    static void Main(){
        int[] arr={1,5,3,9,7};
        var second=arr.Distinct().OrderByDescending(x=>x).Skip(1).First();
        Console.WriteLine(second);
    }
}
