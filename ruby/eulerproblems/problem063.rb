# Project Euler problem 63

count = 0

power_max = ((Math.log(10)) / (Math.log(10) - Math.log(9))).to_i

powers = (1..power_max).to_a
bases = (1..9).to_a # x ** n can never have n digits for values of x > 10

count = bases.product(powers).select { |i, j| j == (i ** j).to_s.size }.size
	
puts "The number of n-digit numbers that are nth powers: #{count}"