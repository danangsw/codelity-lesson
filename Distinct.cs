// That, given an array A consisting of N integers, returns the number of distinct values in array A.

// Assume that:

// N is an integer within the range [0..100,000];
// each element of array A is an integer within the range [−1,000,000..1,000,000].
// For example, given array A consisting of six elements such that:
//  A[0] = 2    A[1] = 1    A[2] = 1
//  A[3] = 2    A[4] = 3    A[5] = 1
// the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

// Result: https://app.codility.com/demo/results/trainingYQAWU8-9HV/

using System;

class Solution {
    public int solution(int[] A) {
        int count = 0;
        int a = -1000001;
    
        Array.Sort(A);
        
        for(int i=0; i<A.Length; i++) {
            // Console.WriteLine(A[i]);
            if((A[i] ^ a) != 0) {
                count++;
            }
            a = A[i];
        }
        
        return count;
    }
}
