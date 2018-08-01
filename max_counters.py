from collections import defaultdict

def solution(N, A):
    correction_factor = 0
    max_occurrences = 0

    dct_counters = defaultdict(lambda: 0)

    for element in A:
        if element < N + 1:
            if dct_counters[element] < correction_factor:
                dct_counters[element] = 1 + correction_factor
            else:
                dct_counters[element] += 1

            if dct_counters[element] > max_occurrences:
                max_occurrences = dct_counters[element]

        else:
            correction_factor = max_occurrences

    for index in range(1, N + 1):
        dct_counters[index] = max(dct_counters[index], correction_factor)

    return [dct_counters[key] for key in sorted(dct_counters)]