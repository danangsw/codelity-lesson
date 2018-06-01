using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(Y <= X) return 0;
        
        int B = X + D;
        int C = (int)Math.Ceiling((decimal)(Y - B)/D);
        
        return C + 1;
    }
}
