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
    return sum(set([x for x in range(3,n,3)] + [x for x in range(5,n,5)]))
    
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
    return sum(set(x))

def method_7(n):
    return sum_dev_by(n, 3) + sum_dev_by(n, 5) - sum_dev_by(n, 15)
    
    
def sum_dev_by(target, n):
    p = (target - 1) / n
    return n * (p * (p + 1)) / 2

times = 100
limit = 1000

print 'Method 1:', exec_time(times, method_1, limit)    
print 'Method 2:', exec_time(times, method_2, limit)
print 'Method 3:', exec_time(times, method_3, limit)
print 'Method 4:', exec_time(times, method_4, limit)
print 'Method 5:', exec_time(times, method_5, limit)
print 'Method 6:', exec_time(times, method_6, limit)
print 'Method 7:', exec_time(times, method_7, limit)