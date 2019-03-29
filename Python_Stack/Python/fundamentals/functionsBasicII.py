#1.
'''
def countdown(num):
    x = []
    for y in range(num, -1, -1):
        x.append(y)
    print(x)
countdown(5)
'''
#2.
'''
def printnreturn(list):
    print(list[0])
    return(list[1])
printnreturn([1,2]))
'''
#3.
'''
def firstnlength(list):
    list[0] = list[0] + len(list)
    return list[0]
print(firstnlength([1,5,4,6,3]))
'''
#4.
'''
y = []
def greaterthansec(list):
    count = 0
    if len(list) > 1:
        for x in range(0, len(list), 1):
            if list[x] > list[1]:
                y.append(list[x])
                count += 1
        print(count)
        return y
    else:
        return False
print(greaterthansec([5,2,3,2,1,4]))
'''
#5.
'''
def lengthvalue(a,b):
    x = []
    for l in range(0, a, 1):
        if l < a:
            x.append(7)
        else:
            return False
    return x
print(lengthvalue(4,7))
'''