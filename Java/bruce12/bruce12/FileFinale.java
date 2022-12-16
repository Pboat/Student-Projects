package bruce12;


/* Daniel Bruce
* 2437650
* 
* Generates 10 random decimal numbers in an array,
* then writes those numbers to a file
* and also writes the total of those numbers in that file too.
*/
import java.util.Scanner;
import java.io.*;
public class FileFinale {

	public static void main(String[] args) 
	throws Exception{
		//file
		File pages = new File("randnum.txt");
		
		
		//create and initialize array
		double[] fun = new double[10];
		for(int x = 0 ; x<fun.length;x++){ 
			fun[x] = Math.random()*11;
		}
		
		//pass values to create and fill out file
		writeTheFile(fun,pages);
		
		//read the file and add total
		
		readTheFile(fun,pages);

		
	}
	//write to the file
	public static void writeTheFile(double funny[], File page){
		//writer
		PrintWriter wright = null;
		try {
			wright = new PrintWriter(page);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
			//create file

		if (page.exists() == false) {
			wright.print(page);
		}
			
		//write to the file
		for(double d : funny){
			wright.println(d);
		}

		wright.close();
	}
	
	public static void readTheFile(double funny[], File page){
		//input
		Scanner inn = null;
		try {
			inn = new Scanner(page);
		} catch (FileNotFoundException e1) {
			e1.printStackTrace();
		}
		
		//read file
		double total = 0;
		while(inn.hasNext()){
			double num = inn.nextDouble();
			total += num;
			System.out.println(num); //print the read numbers
		}
		//print the total
		System.out.printf("The total of these numbers is %.2f", total);
		inn.close();
		
	}
}
