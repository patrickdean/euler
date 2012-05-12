#!usr/bin/env ruby
# Patrick Dean
# Project Euler: #001

def sum_of_multiples num, max
	sum = 0
	count = 1
	while num * count < max
		sum += num * count
		count += 1
	end
	sum
end

number = sum_of_multiples(3, 1000) + sum_of_multiples(5, 1000) - sum_of_multiples(15, 1000)
puts "The sum of multiples of 3 and 5 up to 1000 is #{number}"