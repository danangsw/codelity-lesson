// Given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:

// { i : A ≤ i ≤ B, i mod K = 0 }

// For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.

// Assume that:
//        A and B are integers within the range [0..2,000,000,000];
//        K is an integer within the range [1..2,000,000,000];
//        A ≤ B.

// Result: https://app.codility.com/demo/results/trainingU76T39-XWE/

using System;

class Solution {
    public int solution(int A, int B, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        long C = 0L;
        long A1 = (long)A;
        long B1 = (long)B;

        A1 = A + (K-(A%K));
        B1 = B - (B%K);
        if(A%K==0) A1=A;

        if(A1 == B1) return 1;
        
        // Console.WriteLine("{0} {1}", A1, B1);
        long C1 = (B1/K - A1/K)+1;
        C = C1;
        
        if(C < 0) return 0;
        
        // Console.WriteLine("{0} {1} {2}", A1, B1, C);
        return (int)C;
    }
}
