package bruce15;

import javafx.application.Application;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.layout.*;
import javafx.scene.control.*;
import javafx.geometry.*;


/* Daniel Bruce
 * 2437650
 * 
 * This program functions as an investment calculator
*/

public class InvestBig extends Application {

	public void start(Stage mainStage) {
		//set up gridpane
		GridPane gridPane = new GridPane();
		gridPane.setAlignment(Pos.CENTER);
		gridPane.setPadding(new Insets(20,50,20,50));
		gridPane.setHgap(10);
		gridPane.setVgap(10);
		
		//fill that gridpane
		//labels
		Label investLbl = new Label("Investment Amount: ");
		gridPane.add(investLbl, 0, 0);
		Label yearLbl = new Label("Number of Years: ");
		gridPane.add(yearLbl, 0, 1);
		Label interestLbl = new Label("Annual Interest Rate: ");
		gridPane.add(interestLbl, 0, 2);
		Label outvestLbl = new Label("Future Value: ");
		gridPane.add(outvestLbl, 0, 3);
		//textfields
		TextField investFld = new TextField();
		gridPane.add(investFld, 1, 0);
		TextField yearFld = new TextField();
		gridPane.add(yearFld, 1, 1);
		TextField interestFld = new TextField();
		gridPane.add(interestFld, 1, 2);
		TextField outvestBx = new TextField();
		gridPane.add(outvestBx, 1, 3);
		outvestBx.setEditable(false);
		//button
		Button calculate = new Button("Calculate");
		gridPane.add(calculate, 1, 4);
		GridPane.setHalignment(calculate,HPos.RIGHT);
		
		//event handler
		calculate.setOnAction(e ->{
			//get values from text boxes
			double investment = Double.parseDouble(investFld.getText());
			int years = Integer.parseInt(yearFld.getText());
			double interest = Double.parseDouble(interestFld.getText())/1200;
			//calculate
			double outvestment = investment * Math.pow((1+interest),years*12);
			//output to results textbox
			outvestBx.setText(String.format("$%.2f", outvestment));
		});
		
		
		//construct my investment calculator right now
		Scene scene = new Scene(gridPane);
		mainStage.setTitle("Big Money! Calculate Investments!");
		mainStage.setScene(scene);
		mainStage.show();
		
		
	}
	public static void main(String[] args) {
		launch(args);
	}

}
