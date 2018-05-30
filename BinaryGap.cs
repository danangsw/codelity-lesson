using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
       // write your code in C# 6.0 with .NET 4.5 (Mono)
        string binary = Convert.ToString(N, 2);
		
        char[] binaries = binary.ToCharArray();
		
		int maxN = 0;
		char currX = '1';
		int count0 = 0;
		
		foreach(char x in binaries) {
			if (currX != x) {
				currX = x;
				if(count0 >= maxN) maxN = count0;
				count0 = 0;
			}
			
			if(x == '0') {
				count0++;
			}
		}
        
        return maxN;
    }
}
