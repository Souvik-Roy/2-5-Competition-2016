//Calling a function without calling it
// java version 1.8
//cerner_2^5_2016

import java.io.PrintStream;
import java.lang.reflect.Method;

public class CallWithoutCalling {

	 public static class StrangeException extends RuntimeException {
	        @Override
	        public void printStackTrace(PrintStream s) {
	            for (Method m : CallWithoutCalling.class.getMethods()) {
	                if ("main".equals(m.getName())) continue;
	                try {
	                    m.invoke(null);
	                } catch (Exception e) {
	                    //e.printStackTrace();
	                }
	            }
	        }
	    }

	    public static void secretMethodNotCalledInMain() {
	        System.out.println("First Hand Foundation !");
	    }

	    public static void main(String[] args) {
	        throw new StrangeException();
	    }
}
