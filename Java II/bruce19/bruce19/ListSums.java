package bruce19;

import java.util.ArrayList;
/* Daniel Bruce
 * 2437650
 * 
 * This program adds up all the numbers from a list,
 * so long as it extends Number
 * (part 2)
*/

public class ListSums {

	public static void main(String[] args) {
		//make lists
		ArrayList<Double> decker = new ArrayList<>();
		decker.add(3.3);
		decker.add(4.3);
		decker.add(55.3);
		decker.add(512.31234);
		ArrayList<Byte> bite = new ArrayList<>();
		bite.add((byte)3);
		bite.add((byte)100);
		bite.add((byte)86);
		ArrayList<Integer> intern = new ArrayList<>();
		intern.add(1);
		intern.add(10);
		intern.add(100);
		intern.add(1000);
		intern.add(10000);
		//display lists and their sum
		double total = listAdder(decker); //we are going to reuse this
		System.out.printf("The Double list's elements total up to %.1f \n", total);
		total = listAdder(bite);
		System.out.printf("The Byte list's elements total up to %.1f \n", total);
		total = listAdder(intern);
		System.out.printf("The Integer list's elements total up to %.1f \n", total);
		
		
	}
	
	public static double listAdder(ArrayList<? extends Number> list){
		double f = 0;
		//print numbers and determine sum
		for(Number e:list){
			if (e instanceof Number){
				System.out.print(e + " ");
				f += Double.valueOf(e.toString()); //I do this weird seemingly unnecessary conversion thing cause it freaks out if I pass it a byte object
			}
		}
		System.out.print('\n');
		
		return f;
	}

}
