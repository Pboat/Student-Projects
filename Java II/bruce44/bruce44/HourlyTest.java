package bruce44;
/* Daniel Bruce
 * 2437650
 * 
 * I don't know what's happening or how we got here
 * but we gotta test that hourly class
 */
import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;
import java.time.LocalDate;
class HourlyTest {

	@Test
	public void testTheClass() {
		//define an instance of the class we are testing
		String name = "Scot Bonnie";
		LocalDate ahora = LocalDate.now();
		int ID = 176645;
		double pay = 17.50;
		int hours = 32;
		String job = "Roadie";
				
		Hourly gimmeWage = new Hourly(name,ahora,ID,pay,hours,job);
		//activate the the test
		assertEquals(gimmeWage.getJob(),job);
		assertEquals(gimmeWage.getPayRate(),pay);
		assertTrue(gimmeWage.getHours() == hours);
	}

}
