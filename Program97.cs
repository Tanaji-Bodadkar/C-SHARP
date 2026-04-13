using System;
class Program{
    static void Main(){
        Span<int> s=stackalloc int[3]{1,2,3};
        foreach(var i in s)
            Console.Write(i+"" "");
    }
}
