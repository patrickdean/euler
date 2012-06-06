# Project Euler problem 009

ans = ""
1.upto(1000) do |a|
  (a + 1).upto(1000 - a) do |b|
    c = 1000 - a - b
    ans = "#{a} * #{b} * #{c}" if (a * a + b * b) == c * c
  end
end

puts "The only pythagorean triplet for when a + b + c = 1000: " 
puts "a, b, c = #{ans.gsub(/ \* /, ', ')}"
puts "The product, abc = #{eval(ans)}."