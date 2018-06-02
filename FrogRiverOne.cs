using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// Result: https://app.codility.com/demo/results/trainingQT397Q-TM9/ 

class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        bool[] leavesPos = new bool[X+1];
        int occuppiedPos = 0;
        
        for(int i=0; i<A.Length; i++) {
            int pos = A[i];
            if(!leavesPos[pos] && pos < leavesPos.Length) {
                leavesPos[pos] = true;
                occuppiedPos++;
            }
            
            if(occuppiedPos == X) return i;
        }
        
        return -1;
    }
}
