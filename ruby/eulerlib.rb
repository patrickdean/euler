class Integer
  def factorial
    (1..self.abs).reduce(:*) || 1
  end
  
  def combination r
    self.factorial / ((self - r).factorial * r.factorial)
  end
  
  def permutation r
    self.factorial / (self - r).factorial
  end
  
  def fibonacci
    fib = []
    a, b = 0, 1
    while a < self
      fib << a
      a, b = b, a + b
    end
    fib
  end
end

class Array
  def lcm
    self.reduce(&:lcm)
  end
  
  def sum
    self.reduce(&:+) 
  end
end

def fibonacci limit
  a, b = 0, 1
  while a < limit
    yield a
    a, b = b, a + b
  end
end

def sieve_of_eratosthenes limit
  return [] if limit < 2
  high = ((limit / 2) - 1 + limit % 2)  
  sieve = [true] * (high + 1)  
  num = Math.sqrt(limit).to_i >> 1
  (0..num).each do |i|
    next unless sieve[i]
    low = ((i * (i + 3) << 1) + 3)
    (low...high).step((i << 1) + 3) { |j| sieve[j] = false  }
  end
  [2] + sieve.each_index.map { |i| (i << 1) + 3 if sieve[i] }.compact![0...-1]
end

alias :prime_sieve :sieve_of_eratosthenes 
