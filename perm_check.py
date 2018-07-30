def solution(A):
    if len(A) == 1 and A[0] != 1:
        return 0
    
    A.sort()
    
    if A[0] != 1:
        return 0
        
    differences = [True if abs(current - next) == 1 else False for current, next in zip(A, A[1:])]
    return 1 if all(differences) else 0;