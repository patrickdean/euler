# Project Euler problem 004

class String
  def palindrome?
    self == self.reverse
  end
end

def largest_palindrome low, high
  max = 0
  low.upto(high) do |i|
    low.upto(high) do |j|
      num = i * j
      max = (num > max and num.to_s.palindrome?) ? num : max
    end
  end
  max
end

puts "The largest palindrome made from the produce of two 2-digit numbers is #{largest_palindrome(10, 99)}"

puts "The largest palindrome made from the produce of two 3-digit numbers is #{largest_palindrome(100, 999)}"