#This program output Hello World, from line X!, where X is the line number, in the source code, of the actual print statement itself.
#cerner_2^5_2016
close STDERR;
open FOOBAR,">",\$_;


print!warn,'Hello World, from line ',/(\d+)\.$/,'!';