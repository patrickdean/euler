# Project Euler problem 014

$collatz_hash = { 1 => 1 }

def collatz(n)
	return $collatz_hash[n] if $collatz_hash.has_key? n
    $collatz_hash[n] = n.even? ? collatz(n / 2) + 1: collatz(3 * n + 1) + 1
end

limit = 1_000_000

f = (1..limit).map { |n| collatz(n) }

solution = f.each_with_index.max[1] + 1

puts "The number under #{limit} with the largest collatz series is #{solution}"



