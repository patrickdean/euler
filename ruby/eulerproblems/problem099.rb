
filename = ARGV[0] ? ARGV[0] : 'problem99infile.txt'

file = File.open(filename)

if file
	numbers = []
	file.each_line do |l| 
		line = l.split(',')
		numbers << line[1].to_i * Math.log(line[0].to_i)
	end
	
	max = 0
	index = 0
	numbers.each_with_index do |n, i|
		max, index =  n > max ? [n, i] : [max, index]
	end
	puts "#{index + 1}"
else
	puts "Invalid file!"
end
	
