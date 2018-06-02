// You are given N counters, initially set to 0, and you have two possible operations on them:	
//         increase(X) − counter X is increased by 1,
//         max counter − all counters are set to the maximum value of any counter.

// A non-empty array A of M integers is given. This array represents consecutive operations:
//        if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
//        if A[K] = N + 1 then operation K is max counter.

// For example, given integer N = 5 and array A such that:
//     A[0] = 3
//     A[1] = 4
//     A[2] = 4
//     A[3] = 6
//     A[4] = 1
//     A[5] = 4
//     A[6] = 4

// the values of the counters after each consecutive operation will be:
//     (0, 0, 1, 0, 0)
//     (0, 0, 1, 1, 0)
//     (0, 0, 1, 2, 0)
//     (2, 2, 2, 2, 2)
//     (3, 2, 2, 2, 2)
//     (3, 2, 2, 3, 2)
//     (3, 2, 2, 4, 2)

// The goal is to calculate the value of every counter after all operations.

// For example, given:
//     A[0] = 3
//     A[1] = 4
//     A[2] = 4
//     A[3] = 6
//     A[4] = 1
//     A[5] = 4
//     A[6] = 4

// the function should return [3, 2, 2, 4, 2], as explained above.

// Assume that:
//         N and M are integers within the range [1..100,000];
//         each element of array A is an integer within the range [1..N + 1].

// Result: https://app.codility.com/demo/results/trainingFNM5SF-BFM/

using System;

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int maxCounter = 0;
        int minCounter = 0;
        int[] nArr = new int[N];
        
        for(int i=0; i<A.Length; i++) {
            int idx = A[i] - 1;

            if (idx >= N) 
                idx = N - 1;
            
            if(nArr[idx] <= minCounter)
                nArr[idx] = minCounter;
                
            // increased by 1
            if(A[i] >= 1 && A[i] <= N)
                nArr[idx]++;
                
            if(nArr[idx] > maxCounter)
                maxCounter = nArr[idx];
                
            // max counter
            if(A[i] == N+1) {
                minCounter = maxCounter;
                nArr[idx] = minCounter;            
            }
        }
        
        for(int i=0; i<nArr.Length; i++) {
            if(nArr[i] <= minCounter)
                nArr[i] = minCounter;
        }
        
        return nArr;
    }
}
