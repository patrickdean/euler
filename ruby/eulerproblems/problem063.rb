# Project Euler problem 63

count = 0

(1..100).each do |i|
	(1..100).each do |j|
		count += 1 if j == (i ** j).to_s.size
	end
end
	
puts "The number of n-digit numbers that are nth powers: #{count}"