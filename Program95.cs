using System;
using System.Linq;
class Program{
    static void Main(){
        int[] arr={1,2,4,5};
        int n=5;
        int total=n*(n+1)/2;
        Console.WriteLine(total-arr.Sum());
    }
}
