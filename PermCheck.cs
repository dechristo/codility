using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        if (A.Length == 1 && A.First() != 1)
            return 0;
        
        Array.Sort(A);    
        
        if(A.First() != 1)
            return 0;
            
        bool isSequence = A.Zip(A.Skip(1), (current, next) => (current + 1) == next)
            .All(element => element);
            
        return isSequence ? 1: 0;
    }
}