package bruce11;


class WarShip extends Ship{
	//class vars
	private String type;
	private String nation;
	//constructor
	WarShip(String n, int y, boolean a, String t, String nt){
		super(n,y,a);
		this.type = t;
		this.nation = nt;
	}
	//class funcs
	public String toString(){
		return super.toString() + "Type: " + this.type + ", operated by " + this.nation + "\n";
	}
}
