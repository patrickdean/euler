# Project Euler problem 029

ary = (2..100).to_a

terms = []
ary.product(ary).each { |a, b| terms << a ** b }

count = terms.uniq.size
puts "Unique terms of a**b for 2 <= a <= 100 and 2 <= b <= 100: #{count}"