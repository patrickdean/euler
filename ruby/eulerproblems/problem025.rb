# Project Euler problem 025

def fibonacci limit
    a, b = 0, 1
    while a.to_s.size < limit
        yield a
        a, b = b, a + b
    end
end

digits = 1000
num = []

fibonacci(digits) { |n| num << n }

puts "First Fibonacci term that contains #{digits} digits: #{num.size}"