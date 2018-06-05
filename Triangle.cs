// An array A consisting of N integers is given.
// A triplet (P, Q, R) is triangular if 0 ≤ P < Q < R < N and:

// A[P] + A[Q] > A[R],
// A[Q] + A[R] > A[P],
// A[R] + A[P] > A[Q].
// For example, consider array A such that:
//   A[0] = 10    A[1] = 2    A[2] = 5
//   A[3] = 1     A[4] = 8    A[5] = 20
// Triplet (0, 2, 4) is triangular.

// That, given an array A consisting of N integers, returns 1 if there exists a triangular triplet for this array and returns 0 otherwise.

// Assume that:

// N is an integer within the range [0..100,000];
// each element of array A is an integer within the range [−2,147,483,648..2,147,483,647].

// Result: https://app.codility.com/demo/results/trainingXSWZC8-YH8/

using System;

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        if(A.Length < 3) return 0;
        
        for(int i=0; i<A.Length-2; i++) {
            if( A[i]  == Int32.MaxValue &&
                A[i+1] == Int32.MaxValue &&
                A[i+2] == Int32.MaxValue) {
                return 1;
            }
            
            if(A[i]+A[i+1] > A[i+2])
            {
                return 1;
            }
        }
        
        return 0;
    }
}
