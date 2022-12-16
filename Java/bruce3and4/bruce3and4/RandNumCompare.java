package bruce3and4;

/* Daniel Bruce
 * 2437650
 * 
 * Generates 2 random numbers, compares them, and outputs the difference
*/


public class RandNumCompare {

	public static void main(String[] args) {
		//generate 2 random numbers between 25 and 75
				
		int x = (int)((Math.random()*51)+25); //I tested, this provides the correct bounds
		int y = (int)((Math.random()*51)+25);
		
		//generate the difference
		int z = x - y; 
			
		if (z >= 0){ //determine if the difference is negative
			System.out.println("The Difference between "+x+" and "+y+ " is " + z);}
		else if ( z < 0){ //if so, inverse the sign/
			System.out.println("The Difference between "+x+" and "+y+ " is " + (-z));}
	}

}
