#This program output Hello World, from line X!, where X is the line number, in the source code, of the actual print statement itself.
#cerner_2^5_2016
import sys
import traceback
lineno = None
while True:
    try:
        print 'Hello World, from line %d!' % lineno
        break
    except:
        lineno = traceback.tb_lineno(sys.exc_info()[2])
        continue