# Project Euler problem 003

def largest_factor(n)
  (2..Math.sqrt(n)).each do |x|
    n /= x until n % x != 0 or n == x
  end
  n
end


puts "The largest prime factor of 13195 if #{largest_factor 13195}"

puts "The largest prime factor of 600851475143 if #{largest_factor 600851475143}"