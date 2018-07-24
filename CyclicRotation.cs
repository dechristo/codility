using System;

class Solution {
    public int[] solution(int[] A, int K) {
        if (A.Length <=1)   
            return A;  
        
        for(int rotationStep = 0; rotationStep < K; rotationStep++)
        {
              int lastElement = A[A.Length-1];
               
               for(int arrayIndex = A.Length-1; arrayIndex > 0; arrayIndex--)
                   A[arrayIndex] = A[arrayIndex-1];
                   
                A[0] = lastElement;
        }
        return A;
    }
}