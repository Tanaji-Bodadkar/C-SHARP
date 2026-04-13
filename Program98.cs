using System;
class Program{
    static void Main(){
        int a=5;
        int b=a;
        b=10;
        Console.WriteLine(a);

        int[] x={1};
        int[] y=x;
        y[0]=99;
        Console.WriteLine(x[0]);
    }
}
