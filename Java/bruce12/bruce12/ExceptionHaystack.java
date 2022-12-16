package bruce12;


/* Daniel Bruce
* 2437650
* 
* Generates 10 random numbers in an array,
* then asks the user to correctly guess one of the numbers.
*/
import java.util.Scanner;

public class ExceptionHaystack {

	public static void main(String[] args) {
		//it inputs
		Scanner scantron = new Scanner(System.in);
		//create haystack onions 
		int[] onions = new int[10];
		for(int x = 0 ; x<onions.length;x++){ //initialize with random ints between 0 & 100
			onions[x] = (int)(Math.random()*101);
		}
		
		System.out.println("I've got 10 numbers here, they are between 0 and 100");
		boolean escape = false;
		int pin = -1;
		do{
			System.out.println("Pick a number between 0 and 100");
			String input = scantron.nextLine(); //get input
			if (input.matches("[\\d]{1,3}")){//check input is valid
				int fry = Integer.parseInt(input);
				try{
				pin = returnIndex(onions,fry);//send input and array to method
				escape = true;
				}
				catch(Exception ex){
					System.out.println(ex.getMessage());
					System.exit(0);
				}
			}
			else{
				System.out.println("Bad input! Try inputting another number.");
			}
			
		}while(escape == false);
		//indicate the answer was right
		System.out.println("Correct! " + pin + " was one of the numbers");
		//test's over, turn it in
		scantron.close();
	}
	//checks to see if the specific number is in the array given
	public static int returnIndex(int[]haystack,int needle)
	throws IllegalArgumentException{
		int pin = -1;
		for(int h: haystack){
			if(h == needle){
				pin = h;
				System.out.println(pin);
			}
		}
		if(pin != -1){
			return needle;
		}
		else{
			throw new IllegalArgumentException("Element not found in array");
		}
		
	}

}
