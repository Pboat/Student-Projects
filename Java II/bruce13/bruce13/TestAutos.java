package bruce13;

/* Daniel Bruce
 * 2437650
 * 
 * This program displays a list of "automobiles",
 * and then displays it sorted by year
*/
import java.util.ArrayList;
public class TestAutos  {

	public static void main(String[] args) {
		//define automobiles
		Automobile car = new Automobile("Ford", "Taurus", 2006, 4000.00);
		Automobile truck = new Automobile("Toyota", "Hilux", 2012, 8500.00);
		Automobile van = new Automobile("Dodge", "Caravan", 2004, 5000.00);
		Automobile suv = new Automobile("Chevrolet", "Tahoe", 2020, 47499.99);
		Automobile hatchback = new Automobile("AMC", "Gremlin", 1977, 12000.00);
		Automobile sportsCar = new Automobile("Nissan","370Z",2018,29999.99);
		//fill out array list
		ArrayList<Automobile> parkingLot = new ArrayList<Automobile>();
		parkingLot.add(car);
		parkingLot.add(truck);
		parkingLot.add(van);
		parkingLot.add(suv);
		parkingLot.add(hatchback);
		parkingLot.add(sportsCar);
		System.out.println("Welcome to my car dealership, wanna buy a car?");
		//display cars
		for (int x = 0;x<parkingLot.size();x++) {
			System.out.println(parkingLot.get(x).toString());
		}
		//sort array
		java.util.Collections.sort(parkingLot);
		
		System.out.println("Oh, you want a sorted list of the cars I have? Here ya go!");
		//display again
		for(Automobile a:parkingLot) {
			System.out.println(a.toString());
		}
	}

}
