# Project Euler problem 007

require '../eulerlib.rb'

primes = prime_sieve 200000

puts "The 10001st prime is #{primes[10000]}." 