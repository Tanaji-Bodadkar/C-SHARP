using System;
class Program {
    static void Main() {
        int[,] A={{1,2},{3,4}};
        int[,] B={{5,6},{7,8}};
        int[,] R=new int[2,2];
        for(int i=0;i<2;i++)
        for(int j=0;j<2;j++)
        for(int k=0;k<2;k++)
            R[i,j]+=A[i,k]*B[k,j];
        Console.WriteLine(R[0,0]);
    }
}
