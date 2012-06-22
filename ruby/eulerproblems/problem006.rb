# Project Euler problem 006


def sum_of_squares n
  (1..n).map { |x| x * x }.reduce(:+)
end

def square_of_sum n
  (1..n).reduce(:+) ** 2
end

puts "The difference of the square of the sum and the sum of squares"
puts "of the first x natural numbers:"
puts "x = 10 : #{square_of_sum(10) - sum_of_squares(10)}"
puts "x = 100: #{square_of_sum(100) - sum_of_squares(100)}"