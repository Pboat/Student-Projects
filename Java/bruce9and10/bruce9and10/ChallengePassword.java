package bruce9and10;

/* Daniel Bruce
* 2437650
* 
* The user is tasked with coming up with a password
* that fits a specific pattern.
* 
    1 or more upper case letters
    two lower case letters
    1 or 2 digits
    zero or 1 upper case letters
    any two of this group @#$%^&
	AAbb33D%%
*/
import java.util.Scanner;

public class ChallengePassword {

	public static void main(String[] args) {
		//building a scanner
		Scanner scan = new Scanner(System.in);
		//esc val
		boolean done = false;		
		do{
			System.out.println("Enter the password:");
			String pass = scan.nextLine(); //input
			//I wrote out this whole long string of if statements before realizing I could use regex now
			//use regex to filter
			//System.out.println(pass.toString()+"x");

			if (pass.matches("[A-Z]{1,}[a-z]{2}[\\d]{1,2}[A-Z]?[@#\\$%\\^\\&]{2}")){
				done = true; 
			}	
				
			if (done == false){
				System.out.println("Wrong, try again!");
			}
		}while(done == false);
		System.out.println("done");
		//scanner down
		scan.close();
	}

}
