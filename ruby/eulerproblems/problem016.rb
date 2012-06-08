# Project Euler problem 016


sum = (2**15).to_s.each_char.map(&:to_i).reduce(:+)
puts "The sum of the digits of 2^15 is #{sum}"

sum = (2**1000).to_s.each_char.map(&:to_i).reduce(:+)
puts "The sum of the digits of 2^1000 is #{sum}"