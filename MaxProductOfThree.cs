// A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).

// For example, array A such that:
//  A[0] = -3
//  A[1] = 1
//  A[2] = 2
//  A[3] = -2
//  A[4] = 5
//  A[5] = 6

// contains the following example triplets:
//    (0, 1, 2), product is −3 * 1 * 2 = −6
//    (1, 2, 4), product is 1 * 2 * 5 = 10
//    (2, 4, 5), product is 2 * 5 * 6 = 60

// Your goal is to find the maximal product of any triplet.

// Result: https://app.codility.com/demo/results/trainingSTKE3X-6E3/

using System;

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        int alen = A.Length;
        
        //for(int i=0; i<A.Length; i++) {
        //    Console.Write(A[i]);
        //}
        
        int a = A[0]*A[1]*A[alen-1];
        int b= A[alen-1]*A[alen-2]*A[alen-3];
        
        if(a > b) return a;
        else return b;
    }
}
