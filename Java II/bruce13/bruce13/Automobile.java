package bruce13;
/* Daniel Bruce
 * 2437650
 * 
 * this class represents a kind of automobile
*/
public class Automobile implements Comparable<Automobile> {
	//class vars
	private String make;
	private String model;
	private int year;
	private double price;
	//constructor
	public Automobile(String ma, String md, int y, double p){
		this.make = ma;
		this.model = md;
		this.year = y;
		this.price = p;
	}
	//implement comparable
	@Override
	public int compareTo(Automobile o) {
		//compare by year
		int x = 0; // is zero if equal
		if (this.year < o.year) {
			x = -1;
		}
		else if (this.year > o.year) {
			x = 1;
		}
		
		return x;
	}
	
	//string return func
	
	public String toString() {
		return String.format("Make: %s Model: %s Year: %d Price: $%.2f",this.make,this.model,this.year,this.price);
	}
	
	//getters
	public String getMake() {
		return make;
	}

	public String getModel() {
		return model;
	}


	public int getYear() {
		return year;
	}


	public double getPrice() {
		return price;
	}
	

	
}
