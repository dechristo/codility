using System;
using System.Linq;
using System.Collections.Generic;

class Solution {
    public int[] solution(int N, int[] A) {
        Dictionary<int,int> dctCounters = new Dictionary<int,int>();
        int correctionFactor = 0;
        int maxOcurrences = 0;   

        for(int index=1; index <= N; index++)
            dctCounters[index] = 0;
            
        foreach(int element in A)
        {
            if (element < N + 1) 
            {
                if (dctCounters[element] < correctionFactor)
                    dctCounters[element] = 1  + correctionFactor;
                else
                    dctCounters[element]++;
             
                if (dctCounters[element] > maxOcurrences)
                    maxOcurrences =  dctCounters[element];
            } 
            else
                correctionFactor = maxOcurrences;
        }
      
        for(int index = 1; index <= N; index++)
            dctCounters[index] = Math.Max(dctCounters[index], correctionFactor);
           
        return dctCounters.Values.ToArray();
    }
}