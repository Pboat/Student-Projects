package bruce20;

import java.text.NumberFormat;
/* Daniel Bruce
 * 2437650
 * 
 * This class represents every important detail
 * about an employee
*/


public class Employee {
	//class vars
	private String id;
	private String lastName;
	private String firstName;
	private int salary;
	
	//constructor
	public Employee(String i, String l, String f, int s){
		this.id = i; //constructor vars correspond to first letter of class vars
		this.lastName = l;
		this.firstName = f;
		this.salary = s;
	}
	//string method
	public String toString(){
		NumberFormat n = NumberFormat.getInstance();//use this to format for salary field properly.
		return String.format("ID %s:%s, %s, salary $%s", this.id, this.lastName, this.firstName, n.format(this.salary));
	}
	
	//getters
	public String getId(){
		return this.id;
	}

	public String getLastName(){
		return this.lastName;
	}
	
	public String getFirstName(){
		return this.firstName;
	}
	
	public int getSalary(){
		return this.salary;
	}

}
