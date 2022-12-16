package bruce3and4;

/* Daniel Bruce
 * 2437650
 * 
 * determines the cost of a shirt order based
 * on the number of shirts
*/

import java.util.Scanner;

public class DukeShirtDiscount {

	public static void main(String[] args) {

		final double SHIRT_PRICE = 24.95;
		Scanner input = new Scanner(System.in);
		
		System.out.println("Please enter the number of shirts in your order: ");
		int shirtCount = input.nextInt();
		double discount = 0;
		double shipping = 0;
		
		//determine the shipping cost & discount
		if(shirtCount > 0 && shirtCount < 3){
			shipping = 6.99;
		}
		else if(shirtCount >= 3 && shirtCount < 7){
			shipping = 5.49;
			discount = 0.1;
		}
		else if(shirtCount >= 7 && shirtCount < 10){
			shipping = 4.00;
			discount = 0.2;
		}
		else if(shirtCount > 10){
			discount = 0.3;
		}
		else{//catch incorrect inputs
			System.out.println("ERROR: INVALID INPUT! PLEASE ENTER A POSITIVE WHOLE NUMBER!");
			System.exit(0); //prevent further output & processing
		}
		//determine extended price
		double extPrice = SHIRT_PRICE*shirtCount - (SHIRT_PRICE*shirtCount*discount);
		double total = extPrice + shipping;
		//display totals, formated to proper dollar amounts.
		System.out.println("The extended cost of the order is: $" + (((double)Math.round(extPrice*100))/100));
		//add a zero on the end if the shipping value does not go to 2 decimal places
		if (String.valueOf(shipping).length() <= 3 ){
			System.out.println("The cost of shipping is: $" + shipping + "0");}	
		else{
			System.out.println("The cost of shipping is: $" + shipping);}
		System.out.println("The total cost of the order is: $" + (((double)Math.round(total*100))/100));
		
		//closing time
		input.close();
	}

}
