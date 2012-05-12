#!usr/bin/env ruby
# Patrick Dean
# Project Euler: #002


def fibonacci limit
    a, b = 0, 1
    while a < limit
        yield a
        a, b = b, a + b
    end
end

a = []
fibonacci(4000000) { |x| a << x if x % 2 == 0 }

puts a.inject { |sum, x| sum + x }


