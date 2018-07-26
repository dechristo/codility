using System;
using System.Collections;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        if (A.Length == 0)
            return 1;
            
        Array.Sort(A);
        
        int previous = A[0];
        
        if (previous != 1)
            return 1;
            
        foreach(int element in A.Skip(0))
        {
            if (element - previous > 1)
                return ++previous;
                
            previous = element;
        }
        
        return A.Last() + 1;
    }
}