package bruce7;

/* Daniel Bruce
 * 2437650
 * 
 *Generates an array of random numbers,
 *and produces the minimum and maximum values,
 *all the numbers in the array sorted in ascending order,
 *the number of even and odd numbers in the array,
 *and the sum of all values in the array.
*/

public class RandMinMax {

	public static void main(String[] args) {
		System.out.println("Lets make an array of random numbers and sort it.");
		int randArray [] = new int[8];
		//generate numbers between 50 and 100 and add it to the array
		for (int i = 0;i<randArray.length;i++){
			randArray[i] = (int)(Math.random()*51)+50;
		}
		//sort the array and take the min and max of the array
		int minMax [] = sortArray(randArray);
		System.out.println("The minumum value in the array is " + minMax[0]);
		System.out.println("The maximum value in the array is " + minMax[1]);
		
		int evens = 0;
		int odds = 0;
		//output the array and count numbers by parity
		for (int j: randArray){
			System.out.print(j + " ");
			if (j%2 == 0){
				evens++;
			}
			else if ( j%2 == 1) {
				odds++;
			}
			
		}
		System.out.println();//make a new line after the last loop
		System.out.printf("Evens: %d, odds: %d\n",evens,odds);
		//get the sum of all array elements and print the total
		int sum = 0;
		for (int m: randArray){
			sum += m;
		}
		System.out.printf("Total: %d",sum);
		
	}
	//sort array, return min and max values
	public static int[]sortArray(int[]ar){
		int minMaxArray [] = new int [2];
		for (int k = 0; k < ar.length - 1;k++){
			int currentMin = ar[k];
			int minDex = k;
			for (int l = k + 1; l < ar.length ;l++){
				if (currentMin > ar[l]){
					currentMin = ar[l];
					minDex = l;
				}
			}
			if (minDex != k){
				ar[minDex] = ar[k];
				ar[k] = currentMin;
			}
		}
		
		minMaxArray[0]=ar[0];//min
		minMaxArray[1]=ar[ar.length-1];//max
		return  minMaxArray;
	}
}
