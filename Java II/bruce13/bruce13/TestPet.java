package bruce13;

import java.util.*;

/* Daniel Bruce
 * 2437650
 * 
 * This just displays some pets. Yeah, that's all.
*/

public class TestPet {

	public static void main(String[] args) {
		
		Reptile gecko = new Reptile("Shimmy",'F',new Date(),"Common Leopard Gecko");
		//release the hounds
		Dog dachshund = new Dog("Oscar",'M',new Date(),"Dachshund",26);
		Dog golden = new Dog("Max",'M',new Date(),"Golden Retriever",71);
		Dog bernard = new Dog("Jelvis",'M',new Date(),"St. Bernard",158);
		Dog collie = new Dog("Oreo",'F',new Date(),"Border Collie",38);
		//fill out arraylist
		ArrayList<Dog> kennel = new ArrayList<Dog>();
		kennel.add(dachshund);
		kennel.add(golden);
		kennel.add(bernard);
		kennel.add(collie);
		
		//display reptile
		System.out.println("We have pets!");
		System.out.println(gecko.toString());
		//display the doggies.
		System.out.println("Especially dogs, conviniently sorted by weight");
		//sort
		java.util.Collections.sort(kennel);
		//show me the dogs
		for(Dog d: kennel) {
			System.out.println(d.toString());
		}
		
	}

}
