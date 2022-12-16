package bruce5;

/* Daniel Bruce
* 2437650
* 
* Shows temperatures in Fahrenheit and Celsius
* from -40F to 120F in increments of 5F
*/

public class TempFahrenheitToCelsius {

	public static void main(String[] args) {
		//
		for (double f = -40; f <= 120 ; f+=5){
			double c = ((f - 32.0) * (5.0/9.0));//fahrenheit to celsius conversion
			System.out.print(f + "°F  ");
			System.out.println((Math.round(c*100.0)/100.0) + "°C"); // rounds it to 2 decimal points
		}

	}

}
