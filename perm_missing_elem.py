def solution(A):
    if not len(A):
        return 1
    A.sort()
    previous = A[0]
    if previous != 1:
        return 1
    for element in A[1:]:
        if element - previous > 1:
            return previous + 1
        previous = element
    return A[-1] + 1
    