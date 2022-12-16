package bruce13;
/* Daniel Bruce
 * 2437650
 * 
 * This class represent reptiles
*/
import java.util.Date;

public class Reptile extends Pet implements Mobility {
	//class var
	private String type;
	//constructor
	
	public Reptile(String n, char g, Date a, String t) {
		super(n,g,a);//pass to superclass
		this.type = t;
	}
	//interface method
	public String move() {
		return ("Must be contained, can crawl/slither over rough terrain");
	}
	//passed abstract method
	public String sound() {
		return ("Squeaks or hisses, depending on the reptile");
	}
	
	public String toString() {
		
		return String.format("Reptile's Name: %s, %s, %c \n"+ move()+"\n" + sound() +", %s", this.getName(),this.type,this.getGender(),this.getAcquired().toString());
	}
}
