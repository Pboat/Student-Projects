package bruce7;

/* Daniel Bruce
* 2437650
* 
* Takes in numbers through command line exectution,
* displays them, and displays their sum.
*/

public class SumArgs {
	
	public static void main(String[] args) {
		System.out.print("Passing [");
		//account for 0 args
		if (args.length == 0){
			System.out.print("] \n");
		}
		//print the args
		for (int a = 0; a < args.length ;a++){
			
			if (a < args.length -1){ //true for all but final element
				System.out.print(args[a]+", ");
			}
			else
			{
				System.out.print(args[a]+"]\n");
			}
		}
		int sum = sumInts(args);
		//display total
		System.out.println("The total is: " + sum);
	}
	//sum the args
	public static int sumInts (String garg[]) {
		int sum = 0;
		for (String b: garg){
			sum += Integer.parseInt(b);
		}
		return sum;
	}
}
