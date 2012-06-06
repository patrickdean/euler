# Project Euler problem 010

require '../eulerlib.rb'

primes = prime_sieve 2000000

puts "Sum of all primes below 2000000: #{primes.reduce(:+)}."