#!/usr/bin/env python
# Patrick Dean
# Project Euler: #003
# Find the largest prime factor of n.



n = 600851475143
root = int(n**0.5)
x = 2

while x < root:
    if n % x == 0:
        n /= x
    else:
        x += 1
    if n == 1: break
        
print x