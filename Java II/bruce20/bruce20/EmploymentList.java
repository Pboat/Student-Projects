package bruce20;

/* Daniel Bruce
 * 2437650
 * 
 * This class displays all of the employees' info
 * in various arrangements
*/

import java.util.*;

public class EmploymentList {

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
		
		ArrayList<Employee> staffList = new ArrayList<>(Arrays.asList(staff));
		//sort by first name first so that last name takes priority
		staffList.sort((e1,e2) -> e1.getFirstName().compareToIgnoreCase(e2.getFirstName()));
		//sort by last name
		staffList.sort((e1,e2) -> e1.getLastName().compareToIgnoreCase(e2.getLastName()));
		//display
		System.out.println("Staff sorted by name:");
		System.out.println();
		staffList.forEach(e -> System.out.println(e.toString()));
		System.out.println();
		//"convert" to linked list
		LinkedList<Employee> linkedStaff = new LinkedList<>(staffList);
			
		//iterate
		ListIterator<Employee> staffIterator = linkedStaff.listIterator();
		//forward iteration
		while (staffIterator.hasNext()){
			staffIterator.next();
		}
		System.out.println("Staff sorted by name in reverse:");
		System.out.println();
		//backwards iteration, displays list's contents in reverse
		staffIterator = linkedStaff.listIterator(linkedStaff.size());
		while (staffIterator.hasPrevious()){
			System.out.println(staffIterator.previous().toString());
		}
		System.out.println();
		System.out.println("Done.");
	}

}
