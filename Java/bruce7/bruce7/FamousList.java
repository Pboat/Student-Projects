package bruce7;

/* Daniel Bruce
* 2437650
* 
* List celebrities, then modify that list and display it again
*/

import java.util.*;

public class FamousList {

	public static void main(String[] args) {
		//initialize list
		ArrayList<String> celebrities = new ArrayList<>();
		celebrities.add("Guy Fieri");
		celebrities.add("Norm Macdonald"); //rip ;_;
		celebrities.add("Lady Gaga");
		celebrities.add("Abraham Lincoln");
		celebrities.add("Nicolas Cage");
		//why are we making this list? well...
		System.out.println("These are the top five celebrities who would eat lasagna:");
		//display list
		for (int i=0;i<celebrities.size();i++){
			System.out.println(celebrities.get(i));
		}
		correctList(celebrities);//modify the list
		//print the list again, but using an iterator?
		System.out.println("Great! Anyways, top five celebs who eat lasagna:");
		Iterator<String> iter = celebrities.iterator();
		while (iter.hasNext()){
			System.out.println(iter.next());
		}
	}
	
	public static void correctList(ArrayList<String> cel){
		System.out.println("Oh wait, I that's not right. Gonna have to fix the list. Is this good?");
		cel.add(2,"Arnold Schwarzenegger");
		cel.remove(4);
		for (String x : cel){
			System.out.print("* "+x+" ");
		}
		System.out.print("\n");
	}

}
