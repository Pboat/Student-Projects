package bruce19;


/* Daniel Bruce
 * 2437650
 * 
 * This application looks at arrays of various objects
 * using a generic method
 * (part 1)
*/

public class AcceptingArrays {

	public static void main(String[] args) {
		//make arrays
		Character alphabet[] = {'g','o','o','g','l','e'};
		Integer number[] = {3,66,999};
		String words[] = {"Calliope","Effervescent","Chillax","Salami","This"};
		//display info about them
		System.out.println("This is a Character array:");
		System.out.println("There were "+getElements(alphabet)+ " elements in that array.");
		System.out.println("And This is an Integer array:");
		System.out.println("There's "+getElements(number)+ " elements in this array.");
		System.out.println("Finally, we've got a String array:");
		System.out.println("This array has "+getElements(words)+ " elements.");
	}
	
	public static <E> int getElements(E[] ar){
		//print elements & return length
		for (E e : ar){
		System.out.print(e + " ");
		}
		System.out.print('\n');
		return ar.length;
	}

}
