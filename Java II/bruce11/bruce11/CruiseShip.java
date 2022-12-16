package bruce11;

class CruiseShip extends Ship{
	private int passengers;
	private String zone;
	//constructor
	CruiseShip(String n, int y, boolean a, int p, String z) {
		super(n,y,a);
		this.passengers = p;
		this.zone = z;
	}
	//class funcs
	public String toString(){
		return super.toString() + this.passengers + " passenger capacity, operating in the " + this.zone + "\n";
	}
	//getters
	public int getPassengers(){
		return this.passengers;
	}
	
	public String getZone(){
		return this.zone;
	}
	
}
