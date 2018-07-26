def solution(start_position, end_position, jump_length):
    remaining_distance = (end_position - start_position) % jump_length
    jumps =  int((end_position - start_position) / jump_length)
    return jumps if remaining_distance == 0 else jumps+1
    