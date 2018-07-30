def solution(X, A):
    if len(A) == 1:
        return 0 if X == A[0] else -1;
        
    if not X in A:
        return -1;
        
    if len(A) < X:
        return -1;
        
    positions = set()
    
    for index in range(0, len(A)):
        positions.add(A[index])
        
        if len(positions) == X:
            return index;
    
    return -1;
        