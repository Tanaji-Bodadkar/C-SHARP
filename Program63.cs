using System;
class Program {
    static void Main() {
        string s="hello";
        char[] arr=s.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
}
