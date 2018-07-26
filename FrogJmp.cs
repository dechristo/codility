using System;

class Solution {
    public int solution(int currentPosition, int targetPosition, int jumpingDistance) {
        int remainingDistance = (targetPosition - currentPosition) % jumpingDistance;
        int jumps = (targetPosition - currentPosition) / jumpingDistance;
        return remainingDistance == 0 ? jumps : ++jumps;
    }
}