# Project Euler problem 022

class String
  def score
    each_char.map { |c| c.ord - 64 }.reduce(:+) 
  end
end

file_name = 'infiles/problem022.txt'

names = File.open(file_name).read.split(',').map! { |s| s[/\w+/] }.sort!

total = 0
names.each_with_index { |name, index| total += name.score * (index + 1) }

puts "The total score of the names in the file is #{total}"

