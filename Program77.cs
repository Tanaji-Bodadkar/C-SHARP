using System;
class Program {
    static int Sum(params int[] nums){
        int s=0;
        foreach(int i in nums) s+=i;
        return s;
    }
    static void Main(){
        Console.WriteLine(Sum(1,2,3,4));
    }
}
