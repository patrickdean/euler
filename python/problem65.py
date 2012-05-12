#!/usr/bin/env python
# Patrick Dean
# Project Euler: #065
# Find the sum of digits in the numerator of the 100th convergent of the continued fraction for e.

def e_conv_gen(n):
    s=[[1, 2 * x, 1] for x in xrange(1, n / 3 + 1)]
    v = [2]
    for x in s:
        v += x

    return v[:n]
    
def convergent(lst):
    if len(lst) == 1:
        return (lst[0], 1)
    num, den = convergent(lst[1:])
    return (lst[0] * num + den, num)
    
    
tst = e_conv_gen(10)

tst_res = convergent(tst)
#print tst_res

assert tst_res[0] == 1457
assert tst_res[1] == 536

a = e_conv_gen(100)

result = convergent(a)

#print 'Numerator:', result[0]
#print 'Denominator:', result[1]

print 'Sum of digits:', sum([int(x) for x in str(result[0])])