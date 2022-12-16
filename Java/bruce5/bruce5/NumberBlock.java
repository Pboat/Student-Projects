package bruce5;

/* Daniel Bruce
 * 2437650
 * 
 * makes a big block of numbers
 * between 300 to 200 descending that 
 * are divisible by 11 or 13, but not both
*/

public class NumberBlock {

	public static void main(String[] args) {
		
		int y = 0; //value used to track number of items in a row
		int sum = 0;
		int count = 0;
		for (int x = 300; x >= 200 ; x--){
			//print numbers
			if (x % 11 == 0 ^ x % 13 == 0){ 
				
				String xtring = ""+x;
				while ( xtring.length() < 8){ // ensures a column is 8 wide
					xtring += " ";
				}
					
				System.out.print(xtring);
				y++;
				count++;
				sum += x ;
			}
			//create new row
			if (y >= 5){
				System.out.println("");
				y = 0; //reset tracking value
			}
		}
		//result
		System.out.println("The sum of these " + count + " integers is " + sum + "!");
		
	}

}
