using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        if (A.Length == 2)
            return Math.Abs(A.First() - A.Last());
        
        Dictionary<int,int> sumsLeft = new Dictionary<int,int>();
        Dictionary<int,int> sumsRight = new Dictionary<int,int>();
        int currentLeftSum = A.First();
        int currentRightSum = A.Last();
        
        for (int index = 1; index < A.Length; index++)
        {
            sumsLeft.Add(index, currentLeftSum);   
            sumsRight.Add(A.Length-index, currentRightSum);           
            currentLeftSum += A[index];
            currentRightSum += A[A.Length-index-1];
        }
        
        List<int> differences = new List<int>();;
        
        for(int index = 1; index < sumsLeft.Count; index++)
        {
            differences.Add(Math.Abs(sumsLeft[index] - sumsRight[index]));
        }
        
        return  differences.Min();
    }
}