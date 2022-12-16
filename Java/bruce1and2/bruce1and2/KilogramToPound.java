package bruce1and2;

/* Daniel Bruce
 * 2437650
 * simple kg to lbs converter
*/

import java.util.Scanner;



public class KilogramToPound {
	
	public static void main(String[] args) {
		
		final double WEIGHT_CONVERSION_FACTOR = 2.20462262; //thanks google for the conversion factor
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter the weight in kilograms: ");
		
		float theWeightK = input.nextFloat(); //get input
		
		double theWeightLbs = theWeightK * WEIGHT_CONVERSION_FACTOR; //I did the math
		
		System.out.print("That weight in pounds is: " + theWeightLbs);
		
		input.close(); //close the input so there isn't a memory leak caused by it constantly tracking input

	}

}
