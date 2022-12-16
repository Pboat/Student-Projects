package bruce34;

import javafx.application.Application;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.layout.*;
import javafx.scene.control.*;
import javafx.geometry.*;
import java.sql.*;


/* Daniel Bruce
 * 2437650
 * 
 * This program allows the user to sort through a table in a database
 * by plugging data into SQL commands internally
*/

public class DatabaseOmega extends Application{
	//class wide vars
	private Statement state;
	private TextField tfField = new TextField();
	private TextField tfSort = new TextField();
	private TextField tfCond = new TextField();
	private TextArea taResults = new TextArea();
	@Override
	public void start(Stage mainStage) {
		//initialize database
		DBinit();
		//make a grid pane
		GridPane theGrid = new GridPane();
		theGrid.setAlignment(Pos.CENTER);
		theGrid.setPadding(new Insets(15,35,15,35));
		theGrid.setHgap(5);
		theGrid.setVgap(5);
		
		//labels
		Label lblField = new Label("Field: ");
		theGrid.add(lblField, 0, 0);
		Label lblSort = new Label("Sort: ");
		theGrid.add(lblSort, 0, 1);
		Label lblCond = new Label("Condition: ");
		theGrid.add(lblCond, 0, 2);
		Label lblResults = new Label("Results: ");
		theGrid.add(lblResults, 0, 4);
		
		//text fields
		theGrid.add(tfField, 1, 0);
		theGrid.add(tfSort, 1, 1);
		theGrid.add(tfCond, 1, 2);
		theGrid.add(taResults, 1, 4);
		taResults.setEditable(false);
		
		//buttons
		Button btnSubmit = new Button("Submit");
		theGrid.add(btnSubmit, 1, 3);
		btnSubmit.setOnAction(e -> productQuery());
		
		//Set the scene
		Scene scene = new Scene(theGrid);
		mainStage.setTitle("Look at all of our great products!");
		mainStage.setScene(scene);
		mainStage.show();
	}
	
	private void DBinit() {
		try {
			//load the driver
			Class.forName("com.mysql.cj.jdbc.Driver");
			//make connection
			Connection link = DriverManager.getConnection("jdbc:mysql://localhost/example","root","sesame");
			System.out.println("Database Mounted");
			
			//Make a statement
			
			state = link.createStatement();
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
	}
	//what the button does: submits a query using info from the fields
	private void productQuery() {
		//get text from fields
		String field = tfField.getText();
		String sort = tfSort.getText();
		String cond = tfCond.getText();
		try {
			//construct & execute query
			String query = "select " + field + " from product where " + cond + " order by " + sort;
			ResultSet results = state.executeQuery(query);
			//pull results
			String omega = "";//build from this string
			if (results.next()){
				//do this first iteration outside the loop so that the results don't get pushed forward
				int alpha = strCharCount(field,',') + 1;//gets number of fields entered, seperated by commas
				for (int x = 1;x <= alpha;x++) {
					omega += (results.getString(x) + " ");
				}
				omega += " \n";
				taResults.setText(omega);
				//iterate through the remaining entries in the query
				while(results.next()) {
					alpha = strCharCount(field,',') + 1;
					for (int x = 1;x <= alpha;x++) {
						omega += (results.getString(x) + " ");
					}
					omega += " \n";
				}
			}
			else {
				omega = "None fit that search";	
			}
			taResults.setText(omega);//display results
		}
		catch (SQLException ex) {
			ex.printStackTrace();
		}
		
	}

	public static void main(String[] args) {
		launch(args);
	}
	//convenience function, returns amount of a particular char in a string
	public int strCharCount(String str, char ch) { 
		int y = 0;//char count
		
		for (int x = 0;x<str.length();x++) {
			if (str.charAt(x) == ch) {
				y++;
			}
		}
		return y;
	}

}
