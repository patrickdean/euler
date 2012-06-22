# Project Euler problem 019

require 'date'

months = (1..12).to_a
years = (1901..2000).to_a

result = years.product(months).select do |year, month| 
  Date.new(year, month, 1).sunday? 
end.size

puts "Sundays occuring on the first of the month from 1901-2000: #{result}"