package bruce11;


class CargoShip extends Ship{
	//class vars
	private String cargo;
	private int capacity;
	//constructor
	CargoShip(String n, int y, boolean a, String c, int cap){
		super(n,y,a);
		this.cargo = c;
		this.capacity = cap;
	}
	//class funcs
	public String toString(){
		return super.toString() +"Capacity of "+ this.cargo + " is " + this.capacity + "\n";
	}
	
	public int getCapacity(){
		return this.capacity;
	}
}