#!/usr/bin/env python
# Patrick Dean
# Project Euler: #002
# Find the sum of all even valued Fibonnaci number less than 4,000,000.

def fibonacci(limit = 0):
    a, b = 0, 1
    while True:
        if limit and a > limit:
            break
        yield a
        a, b = b, a + b
        
        
print sum(x for x in fibonacci(4000000) if x % 2 == 0)