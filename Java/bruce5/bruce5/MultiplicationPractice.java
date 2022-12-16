package bruce5;

/* Daniel Bruce
* 2437650
* 
* A program that asks the user multiplication questions
* the user can end the program at any time and see their results.
*/

import java.util.Scanner;

public class MultiplicationPractice {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		
		System.out.println("Practice Multiplication! Enter the letter X to stop the test");
		boolean esc = false;
		int count = 0;
		int score = 0;
		
		while (!esc){
			int x = (int)(Math.random()*10);
			int y = (int)(Math.random()*10);
			int total = x * y;
			int answer = 0;
			boolean strNum = false;
			boolean validInput = true;
			//get input
			do{
				validInput = true;
				System.out.println("What is " + x + (" X ") + y + "?");
				String strAnswer = input.nextLine();
				//determine if the input is a number or letter
				for (int i = 0; i < strAnswer.length();i++){
					if (Character.isDigit(strAnswer.charAt(i))){
						strNum = true;
					}
					else{
						strNum = false;
						break;
					}
				}
				//determine if the input should be evaluated or should end the main loop
				if (strNum) {
					answer = Integer.parseInt(strAnswer);
				}
				else if (!strNum && strAnswer.toLowerCase().contains("x")){//gotta account for the extremely unlikely uppercase X
					esc = true;
					break;
				}
				else{
					validInput = false;
					System.out.println("Invalid Input! Try answering again");
				}
			}while (!validInput);
			if (esc){
				continue;
			}
			count++; //we increment here to prevent non-numerical inputs from counting
			
			//determine if the input was right or wrong
			if (total == answer){
				System.out.println("That's right! The answer was " + answer +"!");
				score++;
			}
			else{
				System.out.println("Incorrect! The answer was " + total +"!");
			}
			
		}
		//output the final score
		System.out.println("You answered " + score + "/" + count + " questions correctly.");
		input.close();
	}

}
