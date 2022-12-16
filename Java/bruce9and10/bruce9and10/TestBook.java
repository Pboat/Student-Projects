package bruce9and10;


/* Daniel Bruce
* 2437650
* 
* Adds books to a list
* and checks what the least expensive book is
* after a discount is applied
*/

public class TestBook {

	public static void main(String[] args) {
		
		//initialize the array and fill it out
		Book[] shelf = new Book[6];
		shelf[0] = new Book("Of Mice and Men","John Stienbeck",107,7.99); 
		shelf[1] = new Book("If You Give a Mouse a Cookie","Laura Numeroff",18,14.99);
		shelf[2] = new Book("MAUS","Art Spiegelman",296,22.99);
		shelf[3] = new Book("Flowers For Algernon","Daniel Keyes",311,9.99);
		shelf[4] = new Book();
		shelf[5] = new Book();
		
		//print out every entry
		for (Book b: shelf){
			System.out.println(b.toString());
		}
		//space it out
		System.out.println();
		//fix array
		finishArray(shelf);
		//apply discount and get most expensive book
		Book priceyBook = reduceBooks(shelf);
		//display again
		for (Book bo: shelf){
			System.out.println(bo.toString());
		}
		//space it out again
		System.out.println();
		//display most expensive book
		System.out.println("The most expensive book on the shelf was:");
		System.out.println(priceyBook.toString());
		//display the number of books
		System.out.println("There were " + Book.numBooks + " books on the shelf.");
		
	}
	
	//fill out the rest of the array (why didn't we do that earlier?)
	public static void finishArray(Book[] bookArray){
		bookArray[bookArray.length-2].setTitle("Micky Mouse Clubhouse - I'm Ready to Read With Mickey Sound Book");
		bookArray[bookArray.length-2].setAuthor("Jennifer H. Keast");
		bookArray[bookArray.length-2].setPages(14);
		bookArray[bookArray.length-2].setPrice(11.99);
		bookArray[bookArray.length-1].setTitle("Three Blind Mice and Other Stories");
		bookArray[bookArray.length-1].setAuthor("Agatha Christie, Joan Hickson, et al.");
		bookArray[bookArray.length-1].setPages(250);
		bookArray[bookArray.length-1].setPrice(11.69);
// 		 ()()
//		 (''>*
	}
	
	//reduce book price
	public static Book reduceBooks(Book[] bookArray){
		Book warAndPeace = new Book();//war and peace is a big book. this will be the most expensive book
		
		for (int b = 0; b< bookArray.length;b++){
			bookArray[b].setPrice(bookArray[b].getPrice()*.6);//reduce price by 40%, leaving us with 60%
			//get the most expensive book from the array
			if (b == 0 || bookArray[b].getPrice() > warAndPeace.getPrice()){
				warAndPeace = bookArray[b];
			}
		}
		return warAndPeace;
	}
}
//book object
class Book {
	//class vars
	private String title;
	private String author;
	private int pages;
	private double price;
	public static int numBooks = 0; //why is this supposed to be public? direct access to this can lead to inconsistent data! we should use a getter, right?
	
	//constructors
	Book(){
		numBooks++;
	}
	
	Book(String ti,String auth,int pg, double pr){
		this.title = ti;
		this.author = auth;
		this.pages = pg;
		this.price = pr;
		numBooks++;
	}
	//returns a string that contains all the data in a book object
	public String toString(){
		//price is formatted to display like a dollar amount would.
		return String.format("Book Title: %s, Author: %s, Pages: %d, Price: $%.2f", this.title, this.author, this.pages, this.price);
	}
	//getters
	public String getTitle(){
		return this.title;
	}
	public String getAuthor(){
		return this.author;
	}
	public int getPages(){
		return this.pages;
	}
	public double getPrice(){
		return this.price;
	}
	
	//setters
	public void setTitle(String ti){
		this.title = ti;
	}
	public void setAuthor(String auth){
		this.author = auth;
	}
	public void setPages(int pg){
		this.pages = pg;
	}
	public void setPrice(double pr){
		this.price = pr;
	}
}
