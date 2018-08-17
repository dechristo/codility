def solution(A):
    passing_cars = 0
    previous_passing_cars = 0
    is_passing = False
    
    for index in range(0, len(A)):
        if A[index] == 0:
            is_passing = True
            previous_passing_cars += 1
            continue
        
        if A[index] == 1 and is_passing:
            passing_cars += 1*previous_passing_cars
        else:
            is_passing = False
            
        if passing_cars > 1000000000:
            return -1
            
    return passing_cars