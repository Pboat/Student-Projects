package bruce13;
/* Daniel Bruce
 * 2437650
 * 
 * This class represents man's best friend, dogs!
*/
import java.util.Date;

public class Dog extends Pet implements Mobility, Comparable<Dog> {
	//class vars
	private String breed;
	private int weight;
	//constructor
	public Dog(String n, char g, Date a, String b, int w) {
		super(n,g,a);//pass to superclass
		this.breed = b;
		this.weight = w;
	}
	//interface methods
	public String move() {
		return ("Can be transported with a leash");
	}
	
	public int compareTo(Dog d) {
		//compare by weight
		int x = 0;
		if (this.weight < d.weight) {
			x = -1;
		}
		else if (this.weight > d.weight) {
			x = 1;
		}
		return x;
	}
	
	//passed abstract method
	public String sound() {
		return ("Goes woof woof bark arf arf");
	}	
	
	//class method
	
	public String toString() {
		
		return String.format("Dog's Name: %s, %s, %c \n"+ move()+", weighs %d lbs\n" + sound() +", %s", this.getName(),this.breed,this.getGender(),this.weight,this.getAcquired().toString());
	}

}
