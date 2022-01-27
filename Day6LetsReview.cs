using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int T = Convert.ToInt32(Console.ReadLine());
        
        for(int k=1;k<=T;k++)
        {
            string S = Console.ReadLine();
            int strlen = S.Length;
             
            for(int i=0;i<strlen;i++)
            {
             Console.Write(S[i]);
             i++;
            }
            Console.Write(" ");
            for(int j=1;j<strlen;j++)
            {
                Console.Write(S[j]);
            j++;
            }
        Console.WriteLine();
            }
        
       
        
        
        
        
    }
}
