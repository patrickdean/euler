#!/usr/bin/env python
# Patrick Dean
# Project Euler: #006
# Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


def result(n):
    r1 = sum(x * x for x in range(n + 1))
    r2 = sum(range(n + 1)) ** 2
    return r2 - r1
    
print 'Difference of sum of squares and square of sums:', result(100)