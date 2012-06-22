# Project Euler problem 017

class Integer
  def char_count
    case self
    when 1, 2, 6, 10
        3
    when 3, 7, 8
        5
    when 4, 5, 9
        4
    when 11, 12
        6
    when 13, 14, 18, 19
        8
    when 15, 16
        7
    when 17
        9
    when 20..39, 80..99
        6 + (self % 10).char_count
    when 40..69
        5 + (self % 10).char_count
    when 70..79
        7 + (self % 10).char_count
    when 100..999
        temp = (self / 100).char_count + 7
        temp += 3 + (self % 100).char_count unless self % 100 == 0
        temp
    when 1000
        11
    else
        0
    end
  end
end


result = (1..1000).map(&:char_count).reduce(:+)

puts "Sum of the number of characters of 1..1000 written as words: #{result}."