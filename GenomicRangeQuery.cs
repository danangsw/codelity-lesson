// A DNA sequence can be represented as a string consisting of the letters A, C, G and T, 
// which correspond to the types of successive nucleotides in the sequence. Each nucleotide has an impact factor, 
// which is an integer. Nucleotides of types A, C, G and T have impact factors of 1, 2, 3 and 4, respectively. 
// You are going to answer several queries of the form: What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?

// The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N-1] consisting of N characters.
// There are M queries, which are given in non-empty arrays P and Q, each consisting of M integers.
// The K-th query (0 ≤ K < M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence between positions P[K] and Q[K] (inclusive).

// For example, consider string S = CAGCCTA and arrays P, Q such that:
//  P[0] = 2    Q[0] = 4
//  P[1] = 5    Q[1] = 5
//  P[2] = 0    Q[2] = 6

// The answers to these M = 3 queries are as follows:
// 1. The part of the DNA between positions 2 and 4 contains nucleotides G and C (twice), whose impact factors are 3 and 2 respectively, so the answer is 2.
// 2. The part between positions 5 and 5 contains a single nucleotide T, whose impact factor is 4, so the answer is 4.
// 3. The part between positions 0 and 6 (the whole string) contains all nucleotides, in particular nucleotide A whose impact factor is 1, so the answer is 1.

// Result: https://app.codility.com/demo/results/trainingB9T7Q6-EFV/

using System;

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] R = new int[P.Length];
        int[,] prefixs = new int[S.Length,4];
        
        for(int i = 0; i < S.Length; i++) {
            if(S[i] == 'A') prefixs[i,0] = 1;
            if(S[i] == 'C') prefixs[i,1] = 1;
            if(S[i] == 'G') prefixs[i,2] = 1;
            if(S[i] == 'T') prefixs[i,3] = 1;
            
            // Console.Write(S[i]);
        }
        // Console.WriteLine();
        
        for(int i = 1; i < S.Length; i++) {
            for(int j = 0; j < 4; j++) {
                prefixs[i,j] += prefixs[i-1,j];
                // Console.Write(prefixs[i,j]);
            }
            // Console.WriteLine();
        }
        
        for(int i = 0; i < P.Length; i++) {
            int p = P[i];
            int q = Q[i];

            for(int j = 0; j < 4; j++) {
                int diff = 0;
                
                if(p-1 >= 0) diff = prefixs[p-1,j];
                if(prefixs[q,j] - diff > 0) {
                    R[i] = j + 1;
                    break;
                }
            }
        }
        
        return R;
    }
}
