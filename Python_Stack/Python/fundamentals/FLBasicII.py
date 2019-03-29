#1.
'''
def biggie(list):
    newArr = []
    for x in range(0, len(list), 1):
        if list[x] > 0:
            newArr.append("big")
        else:
            newArr.append(list[x])
    return newArr
print(biggie([-1,3,5,-5]))
'''
#2.
'''
def countpos(list):
    x = 0
    y = []
    for l in range(0, len(list), 1):
        if list[l] > 0:
            x += 1
        y.append(list[l])
    y.pop(y[len(y)-1])
    y.append(x)
    return y
print(countpos([-1,1,1,1]))
'''
#3.
'''
def sumtotal(list):
    y = 0
    for x in range(0, len(list), 1):
        y = y + list[x]
    return y
print(sumtotal([1,2,3,4]))
'''
#4.
'''
def average(list):
    sum = 0
    for x in range(0, len(list), 1):
        sum = sum + list[x]
    return sum / len(list)
print(average([1,2,3,4]))
'''
#5.
'''
def length(list):
    return len(list)
print(length([1,2,3,4,5,6]))
'''
#6.
'''
def minime(list):
    y = list[0]
    if len(list) >= 1:
        for x in range(1, len(list), 1):
            if list[x] < y:
                y = list[x]
    else: return "False"
    return y
print(minime([37,2,1,-9]))
'''
#7.
'''
def maximum(list):
    y = list[0]
    if len(list) <= 0:
        return False
    else:
        for x in range(1, len(list), 1):
            if list[x] > y:
                y = list[x]
        return y
print(maximum([37,2,1,-9]))
'''
#8.
'''
def ultimate(list):
    sumTotal = 0
    average = 0
    minimum = list[0]
    maximum = list[0]
    for x in range(0, len(list), 1):
        sumTotal = sumTotal + list[x]
        if list[x] < minimum:
            minimum = list[x]
        if list[x] > maximum:
            maximum = list[x]
    average = sumTotal / len(list)
    y = {"sumTotal": sumTotal,"average": average,"minimum": minimum,"maximum": maximum}
    return y
print(ultimate([37,2,1,-9]))
'''
#9.
'''
def reverse(list):
    j = len(list)
    for x in range(0, int(j/2), 1):
        temp = list[x]
        list[x] = list[len(list)-1-x]
        list[len(list)-1-x] = temp
    return list
print(reverse([37,2,1,-9,6]))
'''