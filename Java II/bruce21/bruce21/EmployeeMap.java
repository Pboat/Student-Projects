package bruce21;

/* Daniel Bruce
 * 2437650
 * 
 * Sorts employees into a list, but with a tree map this time
*/
import java.util.*;
public class EmployeeMap {

	public static void main(String[] args) {
		//create employee array
		Employee staff[] = {new Employee("61126","Peterson","Penelope",46000),
							new Employee("52621","Smith","Ryan",59000),
							new Employee("57925","Marbury","Sheila",63000),
							new Employee("42307","Gustav","Jan",81000),
							new Employee("41153","Smith","Tania",81000),
							new Employee("53313","Bryzgalov","Neil",66000),
							new Employee("61939","Horton","Samantha",43000),
							new Employee("65773","Burr","Ryan",45000)};
		//list made from above		
		ArrayList<Employee> staffList = new ArrayList<>(Arrays.asList(staff));
		//display employees in array order
		System.out.println("Here are all of the employees: \n");
		for(Employee e: staffList){
			System.out.println(e);
		}
		System.out.println();//for spacing
		// here comes that tree set
		TreeMap<String,Employee> staffTree = new TreeMap<>();
		staffList.forEach(e-> staffTree.put(e.getId(), e));
		//display the ordered employee map
		System.out.println("Employees, ordered by ID number: \n");
		staffTree.forEach((i,e)-> System.out.println(e));
		//done, happy thanksgiving :)	
	}

}
