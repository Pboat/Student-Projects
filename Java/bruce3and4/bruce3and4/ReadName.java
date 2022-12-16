package bruce3and4;

/* Daniel Bruce
 * 2437650
 * 
 * this reads the input name and spits
 * out fun facts about it
*/

import java.util.Scanner;

public class ReadName {

	
	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		//prompt
		System.out.println("Please enter your first name, middle name, and last name:");
		//inputing it like this actually forces 3 individual inputs, which is what we want
		String firstName = input.next();
		String middleName = input.next();
		String lastName = input.next();
		String fullName = firstName + " " + middleName + " " + lastName; //concatenate the names + spaces
		//print the results
		System.out.println("The length of your name is: " + fullName.length()); //
		System.out.println("The length of your middle name is: " + middleName.length());
		System.out.println("Your initials are: " + firstName.charAt(0)+ middleName.charAt(0)+ lastName.charAt(0));
		System.out.println(fullName.toUpperCase());
		
		//close input
		input.close();
	}

}
