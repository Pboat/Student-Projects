package bruce19;

/* Daniel Bruce
 * 2437650
 * 
 * This program finds the maximum number
 * out of 10 user input numbers
 * (part 3)
*/
import java.util.Scanner;

public class MaximumInput {

	public static void main(String[] args) {
		//make a scanner
		Scanner scan = new Scanner(System.in);
		//make an array and fill it out
		Integer numberPack[] = new Integer[10];
		System.out.println("Enter 10 numbers, and I'll say which one is the biggest:");
		for (int i = 0;i<numberPack.length;i++){
			numberPack[i] = (Integer)scan.nextInt();
		}
		System.out.println("Here's the largest number you entered: " + max(numberPack));
		
		//close scanner
		scan.close();

	}
	
	public static <E extends Comparable<E>> E max(E[] list){ //E
		E mx = list[0];
		//search for the max value
		for (E e:list){
			//System.out.println(e);
			
			if (mx.compareTo(e)<0){
				mx = e;
			}
		}
		return mx;
	}

}
