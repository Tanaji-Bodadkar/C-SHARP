using System;
class Program{
    static void Main(){
        int[][] j=new int[2][];
        j[0]=new int[]{1,2};
        j[1]=new int[]{3,4,5};
        foreach(var row in j)
            foreach(var i in row)
                Console.Write(i+"" "");
    }
}
