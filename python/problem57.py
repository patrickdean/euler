#!/usr/bin/env python
# Patrick Dean
# Project Euler: #057
# In the first one-thousand expansions of the continued fraction of sqrt(2), find the number fractions contain a numerator with more digits than denominator


def two_conv_gen(n):
    s= [2] * n
    return [1] + s

def convergent(lst):
    if len(lst) == 1:
        return (lst[0], 1)
    x = lst[-1:]
    i = 1
    num, den = x[0], 1
    while i < len(lst):
        i += 1
        num, den = x[0] * num + den, num
        x = lst[-(i+1):]
    return (num, den)

l = two_conv_gen(1000)
    
x = [convergent(l[:i]) for i in range(1, len(l))]
    
    
print sum(1 for a, b in x if len(str(a)) > len(str(b)))