"""def count_small(numbers):
    total = 0
    for n in numbers:
        if n < 10:
            total = total + 1
    return total

lost = [4, 8, 15, 16, 23, 42]
small = count_small(lost)
print (small);"""

"""def fizz(x):
    count = 0
    for item in x:
        if item == "fizz":
            count = count + 1
    return count

print(fizz(["fizz","cat","fizz"]) )"""

prices = {
    "banana" : 4,
    "apple"  : 2,
    "orange" : 1.5,
    "pear"   : 3,
}
stock = {
    "banana" : 6,
    "apple"  : 0,
    "orange" : 32,
    "pear"   : 15,
}
total = 0
for key in prices:
    #print key;
    print "price: %s" % prices[key]
    print "stock: %s" % stock[key]
    print prices[key] * stock[key]
    total += prices[key] * stock[key]
    
print total



