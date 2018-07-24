def solution(A, K):
    if len(A) <= 1:
        return A
    for rotationStep in range(1, K+1):
        lastElement = A[len(A)-1]
        for index in range(1, len(A)+1):
            A[len(A)-index] = A[len(A)-index-1]
        A[0] = lastElement
    return A