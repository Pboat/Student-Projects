package bruce13;
/* Daniel Bruce
 * 2437650
 * 
 * This class represents the generic concept of a pet
*/
import java.util.Date;
public abstract class Pet {
	//class vars
	private String name;
	private char gender; //a char???
	private Date acquired;
	
	//constructor
	public Pet(String n, char g, Date a) {
		this.name = n;
		this.gender = g;
		this.acquired = a;
	}
	//getters
	public String getName() {
		return name;
	}

	public char getGender() {
		return gender;
	}

	public Date getAcquired() {
		return acquired;
	}
	
	public abstract String sound();
}
