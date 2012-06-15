# Project Euler problem099

numbers = []
File.open('infiles/problem099.txt').each do |line|
  line = line.split(',').map(&:to_i)
  numbers << line[1] * Math.log(line[0])
end
	
max = 0
index = 0
numbers.each_with_index do |n, i|
  max, index =  n > max ? [n, i] : [max, index]
end

puts "Index of the largest number: #{index + 1}"
