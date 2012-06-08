# Project Euler problem 013.rb

numbers = File.open('infiles/problem013.txt').each.map(&:to_i)

digits = numbers.reduce(:+).to_s[0..9]
puts "The first 10 digits of the sum of numbers is #{digits}"
