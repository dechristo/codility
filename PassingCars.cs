using System;

class Solution {
    public int solution(int[] A) {
        bool isPassing = false;
        int passingCars = 0;
        int previousPassingCars = 0;
       
        for (int index = 0; index < A.Length; index++)
        {
            if (A[index] == 0)
            {
                previousPassingCars++;   
                isPassing = true;
                continue;
            }
            
            if (A[index] == 1 && isPassing)
                   passingCars += 1*previousPassingCars;
            else 
                isPassing = false;
            
            if (passingCars  > 1000000000)
                return -1;
        }
        
        return passingCars;
    }
}