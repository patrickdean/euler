# Project Euler Problem 002

def fibonacci n
  a, b = 0, 1
  while a < n
    yield a
    a, b = b, a + b
  end
end

terms = []
fibonacci(4000000) { |x| terms << ( x.odd? ? x : 0 )}
sum = terms.reduce(:+)

puts "The sum of even valued fibonacci numbers less than 4000000 is: #{sum}."