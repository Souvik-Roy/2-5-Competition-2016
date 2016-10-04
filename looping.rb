#Loop without 'looping'. without while, for, do while, foreach or goto. without recursion of function.  

#cerner_2^5_2016

def method_missing(meth,*args)

  puts 'Loop'

  send(meth.next)

end



def also

  puts "++Stop++"

end



ahem