using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// Result: https://app.codility.com/demo/results/trainingDAG2UA-3HR/

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
		if(A.Length == 0) return 1;
		
		long[] aLongs = A.Select(item => (long)item).ToArray();
        Array.Sort(aLongs);
        int lenA = aLongs.Length;
        long min = aLongs[0];
		long max = lenA + 1;
		
		if(min > 1) return 1;
		if(aLongs[aLongs.Length-1] != max) return (int)max;
		        
        double normSum = (max*(1+max))/2;
		
        long aSum = aLongs.Sum();
        
        return (int)(normSum - aSum);
    }
}
