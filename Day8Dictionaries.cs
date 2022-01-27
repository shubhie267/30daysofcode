using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int n = Convert.ToInt32(Console.ReadLine());
         Dictionary<string , string> phoneBook = new Dictionary<string, string>();
         
         
        for(int i=1;i<=n;i++)
        {
            string[] queries = Console.ReadLine().Split(' ');
            var name = queries[0];
            var phno = queries[1];
            phoneBook.Add(name,phno);
        }
 
        string a;
         while((a = Console.ReadLine()) != null)
       {
            if(phoneBook.ContainsKey(a) && phoneBook[a]!=null)
            {
                Console.WriteLine(a+"="+phoneBook[a]);
            }
            else{
                Console.WriteLine("Not found");
            }
        }
    }
}
