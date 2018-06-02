using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// result test: https://app.codility.com/demo/results/trainingPJKA38-GQQ/ 

class Solution {
    public int solution(int[] A) {
        int alen = A.Length;
		long[] P1 = new long[alen-1];
		long[] P2 = new long[alen-1];
		
		long sumA1 = 0L;
		for(int i = 0; i < alen-1; i++) {
			sumA1 += A[i];
			P1[i] = sumA1;
		}
		
		long sumA2 = 0L;
		for(int i = alen-1; i > 0; i--) {
			sumA2 += A[i];
			P2[i-1] = sumA2;
		}
		
		long diff = 0;
		long min = Int64.MaxValue;
		for(int i = 0; i < P1.Length; i++) {
			diff = P1[i] - P2[i];
			diff = diff > 0 ? diff : diff * -1;
			min = diff < min ? diff : min;
			// Console.WriteLine("{0} {1}", P1[i], P2[i]);
		}
        return (int)min;
    }
}
