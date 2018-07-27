def solution(A):
    if len(A) == 2:
        return abs(A[1]-A[0])
        
    sums_left = {}
    sums_right = {}
    current_left_sum = A[0]
    current_right_sum = A[-1]
    
    for index in range(1, len(A)):
        sums_left[index] = current_left_sum
        sums_right[len(A)-index] = current_right_sum
        current_left_sum += A[index]
        current_right_sum += A[len(A)-index-1]
    
    differences = []
    
    for index in range(1, len(A)):
        differences.append(abs(sums_left[index] - sums_right[index]))
        
    return  min(differences);