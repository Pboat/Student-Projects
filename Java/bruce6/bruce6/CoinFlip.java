package bruce6;

/* Daniel Bruce
 * 2437650
 * 
 * Flips a "coin" for the user as many times as the user wants,
 * outputting the results
*/

import java.util.Scanner;

public class CoinFlip {

	public static void main(String[] args) {
		//vars initialization
		Scanner input = new Scanner(System.in);
		int flipNum = 0;
		int headsCount = 0;
		int tailsCount = 0;
		String coin = "";
		
		System.out.println("Flip a coin!");
		//ask for the number of coin flips
		System.out.println("How many times do you want to flip it?");
		String answer = input.nextLine();
		flipNum = Integer.parseInt(answer);
		//loop for every flip
		for (int c = flipNum;c > 0; --c){
			//System.out.println(flip());
			coin = flip();
			if (coin.contains("Heads")){
				headsCount++;
			}
			else if (coin.contains("Tails")) {
				tailsCount++;
			}
		}
		//print out the results
		System.out.printf("After flipping it %d times, here's what it landed on:\n",flipNum);
		System.out.printf("Heads: %d Tails: %d ",headsCount,tailsCount);
		input.close();

	}
	
	//randomly generate which side of the coin it is
	public static String flip(){
	String result = "";
	double randNum =(int) (Math.random()*2); //makes randNum either 1 or 0
	if (randNum == 0){
		result = "Heads";
	}
	else{
		result = "Tails";
	}
	return result;
	}
}
