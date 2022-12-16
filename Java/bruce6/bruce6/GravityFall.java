package bruce6;

/* Daniel Bruce
 * 2437650
 * 
 * Generates a table for the distance an object
 * covers every second while falling, in both meters and feet
*/

public class GravityFall {

	public static void main(String[] args) {
		
		double distMeters = 0.0;
		double distFeet = 0.0;
		//print header
		System.out.println("SEC    METERS      FEET");
		// main loop
		
		for (int t = 1; t <= 10 ; t++){ //t = time in seconds
			distMeters = distOverTime(t);
			distFeet = metersToFeet(distMeters);
			//output formated results
			System.out.printf("%-3d     %5.1f    %6.1f\n",t,distMeters,distFeet);
		}

	}
	//Auxiliary methods
	public static double distOverTime(int t){
		final double G = 9.8;//standard gravitational acceleration
		double result = 0.5*G*Math.pow(t, 2);
		return result;
	}
	
	public static double metersToFeet(double m){
		final double CONVERSION_FACTOR = 3.28084;
		double result = m * CONVERSION_FACTOR;
		return result;
	}

}
