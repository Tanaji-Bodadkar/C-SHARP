using System;
class Program {
    static void Main() {
        int[] arr = {10,20,30};
        int key = 20;
        bool found = false;
        foreach(int i in arr){
            if(i==key){found=true; break;}
        }
        Console.WriteLine(found?"Found":"Not Found");
    }
}
