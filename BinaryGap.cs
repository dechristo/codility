using System;

class Solution {
    public int solution(int N) {
        string binaryRepresentation = Convert.ToString(N,2);
        char currentCharacter;
        int largestGap = 0;
        int gapCounter = 0;
        bool counterStarted = false;
        
        for(int index = 0; index < binaryRepresentation.Length; index++)
        {
            currentCharacter = binaryRepresentation[index];
        
            if (currentCharacter == '0')
            {
                if (counterStarted)
                {
                    gapCounter++;
                    continue;
                }
            };
                
            if (currentCharacter == '1')
            {
                if(counterStarted)
                {                   
                    largestGap = gapCounter > largestGap ? gapCounter : largestGap;
                    gapCounter=0;
                    continue;
                }
                counterStarted = true;
            }
        }
        
        return largestGap;
    }
}