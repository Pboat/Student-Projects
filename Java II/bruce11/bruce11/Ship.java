package bruce11;

class Ship{
	//class variables
	private String name;
	private int year;
	private boolean isAfloat;
	//constructor
	Ship(String n, int y, boolean a){
		this.name = n;
		this.year = y;
		this.isAfloat = a;
	}
	//class function(s)
	public String toString(){
		return ("Ship name: " + this.name+ ", year launched: " + this.year + ", is afloat: " + this.isAfloat +"\n");
	}
	
	//getters
	
	public String getName(){
		return this.name;
	}
	
	public int getYear(){
		return this.year;
	}
	
	public boolean getIsAfloat(){
		return this.isAfloat;
	}
	//setters
	public void setAfloat(boolean a){
		this.isAfloat = a;
	}
}
