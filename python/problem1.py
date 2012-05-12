#!/usr/bin/env python
# Patrick Dean
# Project Euler: #001
# I experimented with several different methods of solving this one in Python.

import time

def exec_time(n, func, x):
    start = time.time()
    for i in range(n):
        func(x)
    return time.time() - start


def method_1(n):
    return sum(set(range(5,n,5)) | set(range(3,n,3)))
    
def method_2(n):
    return sum([x for x in range(n) if not (x % 3 and x % 5)])
    
def method_3(n):
    return sum([x for x in range(n) if x % 3 == 0 or x % 5 == 0])
    
def method_4(n):
    return sum([x for x in range(3,n,3)] + [x for x in range(5,n,5)])
    
def method_5(n):
    x = []
    for i in range(n):
        if i % 3 == 0 or i % 5 == 0:
            x.append(i)
    return sum(x)

def method_6(n):
    x = []
    for i in range(3, n, 3):
        x.append(i)
    for i in range(5, n, 5):
        x.append(i)
    return sum(x)

def method_7(n):
    return sum_dev_by(n, 3) + sum_dev_by(n, 5) - sum_dev_by(n, 15)
    
    
def sum_dev_by(target, n):
    p = (target - 1) / n
    return n * (p * (p + 1)) / 2

print exec_time(10, method_1, 100000)    
print exec_time(10, method_2, 100000)
print exec_time(10, method_3, 100000)
print exec_time(10, method_4, 100000)
print exec_time(10, method_5, 100000)
print exec_time(10, method_6, 100000)
print exec_time(10, method_7, 100000)