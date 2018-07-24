using System;
using System.Collections;

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
      
        for(int index = 0; index < A.Length-2; index+=2)
        {
            if (A[index] - A[index+1] < 0) 
                return A[index];
        }
        
        return A[A.Length-1];
    }
}