// A non-empty array A consisting of N integers is given.
// A permutation is a sequence containing each element from 1 to N once, and only once.

// For example, array A such that:
//     A[0] = 4
//    A[1] = 1
//     A[2] = 3
//     A[3] = 2

// is a permutation, but array A such that:
//     A[0] = 4
//     A[1] = 1
//     A[2] = 3

// is not a permutation, because value 2 is missing.

// The goal is to check whether array A is a permutation.
// If TRUE the function should return 1.
// If FALSE the function should return 0.

// Assume that:
//     N is an integer within the range [1..100,000];
//     each element of array A is an integer within the range [1..1,000,000,000].

// Result: https://app.codility.com/demo/results/trainingPB2TAV-CM5/

using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Array.Sort(A);
        int alen = A.Length;
        long max = A[alen-1];
        long min = A[0];
        
        long count = 0L;
        for(int i=0; i<alen; i++) {
            count += A[i];
        }
        
        var alist = convertEnum(A);
        bool isUnique = alist.Distinct().Count() == alist.Count();

        // Console.WriteLine("{0} {1}", (max*(max+1))/2, count);
        return ((max*(max+1))/2 == count) && isUnique ? 1 : 0;
    }
    
    private List<int> convertEnum(IEnumerable<int> A) {
        return A.ToList();
    }
}
