# Project Euler problem 030

count = []
2.upto(200000).each do |x|
  count << x if x == x.to_s.each_char.map(&:to_i).reduce(0) { |acc, n| acc + (n ** 5) }
end

puts count