# Project Euler problem 030

def fifth_power_of_digits(n)
  n.to_s.each_char.map(&:to_i).reduce(0) { |acc, n| acc + (n ** 5) }
end

count = []
2.upto(200000).each do |x|
  count << x if x == fifth_power_of_digits(x)
end



puts "Sum of numbers that can be written as fifth powers of "
puts "their digits are: #{count.reduce(:+)}"