#Project Euler Problem 001


def multiples_up_to(n)
  (1...n).select { |x| x % 3 == 0 or x % 5 == 0 }.reduce(:+)
end


puts "Sum of multiples of 3 and 5 less than 10 = #{multiples_up_to(10)}"

puts "Sum of multiples of 3 and 5 less than 1000 = #{multiples_up_to(1000)}"