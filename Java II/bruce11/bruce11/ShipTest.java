package bruce11;

/* Daniel Bruce
 * 2437650
 * 
 * "Creates" and describes various "ships"
 * ""
*/

import java.util.ArrayList;
import java.util.Arrays;
public class ShipTest {

	public static void main(String[] args) {
		
		//boat objects
		Ship boatA = new CruiseShip("The Cancun", 2027, false, 1997, "Gulf of Mexico");
		Ship boatB = new CruiseShip("Sauvignon",2014,true,428,"Red Sea");
		Ship boatC = new CargoShip("Quiver",1989,true,"Lumber",9831);
		CargoShip boatD = new CargoShip("Opportune",2022,true,"Food",32335);
		WarShip boatE = new WarShip("USS Ballista",2007,true,"Destroyer","United States Navy");
		//the boat array
		Ship [] fleet = {boatA,boatB,boatC,boatD,boatE};
		//display by iterating through
		System.out.println("Here are my boats cause I'm so rich");
		for (int s = 0;s<fleet.length;s++){
			System.out.print(fleet[s].toString());
		}
		//make array list from array
		ArrayList<Ship> armada = new ArrayList<>(Arrays.asList(fleet));
		//display again by calling a method
		System.out.println("I'm so rich I'm gonna do it again with new advanced technology");//the technology is methods
		System.out.println(shipShow(armada)+" of these ships sank!");
		//execution ends
	}
	
	static int shipShow(ArrayList<Ship> a){
		//keep track of sunken ships
		int sankCount = 0;
		//replace a specific cargo ship with a warship
		a.remove(2);
		a.add(new WarShip("USS Archon",2024,true,"Air Craft Carrier","United States Navy"));
		for (Ship s:a){
			System.out.print(s.toString());
			if (s.getIsAfloat() == false){
				sankCount++;
			}
		}
		
		return sankCount;
	}
	

}
//objects
