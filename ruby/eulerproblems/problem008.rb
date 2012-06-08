# Project Euler problem 008

str = File.open('infiles/problem008.txt').each.to_a.join('')

class Array
  def slice_product len
      max = 0
      (size - len + 1).times do |n|
          a = self[n..-1].take(len)
          prod = a.reduce(:*)
          max = prod > max ? prod : max
      end
      max
  end
end

test_num = 35749641258969482891 # 5 * 8 * 9 * 6 * 9 = 19440

print "The greatest product of 5 consecutive digits of test_num is: "
puts test_num.to_s.each_char.map(&:to_i).slice_product(5)

solution = str.each_char.map(&:to_i).slice_product(5)
puts "The greatest product of 5 consecutive digits of number is: #{solution}"