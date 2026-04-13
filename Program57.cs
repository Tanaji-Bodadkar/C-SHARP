using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        int[] arr = {1,2,2,3,4,4};
        HashSet<int> set = new HashSet<int>(arr);
        foreach(var i in set) Console.Write(i+" ");
    }
}
