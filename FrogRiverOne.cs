using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int solution(int X, int[] A) {
        if (A.Length == 1) 
            return X == A.First() ? 0 : -1;
        
        if (!A.Contains(X))
            return -1;
       
        if (A.Length < X)
            return -1;
 
       HashSet<int> positions = new HashSet<int>();
     
       for(int index = 0; index < A.Length; index++)
       {
            positions.Add(A[index]);  
            
            if (positions.Count == X)
                return index;
       }
           
       return -1; 
    }
}