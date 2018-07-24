def solution(A):
    A.sort()
    for index in range(0, len(A)-1,2):
        if A[index] - A[index+1] < 0: 
            return A[index]
    return A[-1]