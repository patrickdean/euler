# Project Euler problem 020


result = (1..100).reduce(:*).to_s.each_char.map(&:to_i).reduce(:+)

puts "Sum of the digits of 100! = #{result}"