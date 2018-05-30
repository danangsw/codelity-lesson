using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
		int[] B = new int[A.Length];
		
		int idx = 0;
		foreach (int a in A) {
			int shifted = idx + K;
			int idxShifted = shifted;
			if(idxShifted > A.Length - 1) {
				idxShifted = (shifted - A.Length) % A.Length;
			}
			
			B[idxShifted] = a;
			// Console.WriteLine("{0} - {1}", idxShifted, a);
			idx++;
		}
    
        return B;
    }
}
