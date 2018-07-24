def solution(N):
    binaryRepresentation = "{0:b}".format(N)
    counterStarted = False
    largestGap = 0
    gapCounter = 0
    for character in binaryRepresentation:
        if character == '1':
            if counterStarted:
                largestGap = gapCounter if gapCounter > largestGap else largestGap
                gapCounter = 0
                continue
            counterStarted = True
            continue
        if character == '0':
            if counterStarted:
                gapCounter+=1
    return largestGap