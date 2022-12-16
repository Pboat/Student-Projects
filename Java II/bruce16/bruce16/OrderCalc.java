package bruce16;


import javafx.stage.Stage;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.*;
import javafx.scene.control.*;
import javafx.geometry.*;
import java.text.NumberFormat;


/* Daniel Bruce
 * 2437650
 * 
 * This program lets you calculate the cost of an order.
*/

public class OrderCalc extends Application {

	
	@Override
	public void start(Stage mainStage){
		//make our grid pane
		GridPane panetone = new GridPane();
		panetone.setAlignment(Pos.CENTER);
		panetone.setPadding(new Insets(20,20,20,20));
		panetone.setHgap(10);
		panetone.setVgap(10);
		
		//add elements
		//labels
		Label itemLbl = new Label("Item");
		panetone.add(itemLbl,0,0);
		Label priceLbl = new Label("Price");
		panetone.add(priceLbl,0,1);
		Label quantityLbl = new Label("Quantity");
		panetone.add(quantityLbl,0,2);
		Label shippingLbl = new Label("Shipping");
		panetone.add(shippingLbl,0,4);
		Label dayLbl = new Label("Next Day");
		panetone.add(dayLbl,0,5);
		Label weekLbl = new Label("This Week");
		panetone.add(weekLbl,0,6);
		Label standardLbl = new Label("Standard");
		panetone.add(standardLbl,0,7);
		Label totalLbl = new Label("Total Due");
		panetone.add(totalLbl,0,8);
		Label totalCostLbl = new Label("$0.00");//this is the calculated value
		panetone.add(totalCostLbl,1,8);
		//textfields
		TextField itemFld = new TextField();//idk if this one is supposed to do something, but I gave it a function anyways
		panetone.add(itemFld,1,0);
		TextField priceFld = new TextField();
		panetone.add(priceFld,1,1);
		TextField quantityFld = new TextField();
		panetone.add(quantityFld,1,2);
		//checkbox
		CheckBox taxChk = new CheckBox("Taxable?");
		panetone.add(taxChk,1,3);
		//radiobuttons
		RadioButton dayRb = new RadioButton("$20");
		panetone.add(dayRb,1,5);
		RadioButton weekRb = new RadioButton("$12");
		panetone.add(weekRb,1,6);
		RadioButton standardRb = new RadioButton("$5");
		panetone.add(standardRb,1,7);
		ToggleGroup shipGroup = new ToggleGroup();
		dayRb.setToggleGroup(shipGroup);
		weekRb.setToggleGroup(shipGroup);
		standardRb.setToggleGroup(shipGroup);
		//normal buttons
		Button processBtn = new Button("Process");
		panetone.add(processBtn,0,9);
		Button resetBtn = new Button("Reset");
		panetone.add(resetBtn,1,9);
		
		//event handlers
		//calculate button
		processBtn.setOnAction(e -> {
			//pull info from controls
			double itemCost = 0;
			if (priceFld.getText().isEmpty()){//default pricing if empty, but item is not
				if (itemFld.getText().toLowerCase().contains("hammer")){
					itemCost = 20.00;
					priceFld.setText(String.valueOf(itemCost));
				}
				else if(itemFld.getText().toLowerCase().contains("screwdriver")){
					itemCost = 5.00;
					priceFld.setText(String.valueOf(itemCost));
				}
				else if(itemFld.getText().toLowerCase().contains("wrench")){
					itemCost = 15.00;
					priceFld.setText(String.valueOf(itemCost));
				}
				else if(itemFld.getText().toLowerCase().contains("crowbar")){
					itemCost = 25.00;
					priceFld.setText(String.valueOf(itemCost));
				}
			}
			else{ itemCost = Double.parseDouble(priceFld.getText());}
			
			int quantity = Integer.parseInt(quantityFld.getText()); 
			double taxRate = (taxChk.isSelected()?.07:0);//taxrate from picture seems to be 7%
			int shipping = 0;
			if (dayRb.isSelected()){
				shipping = 20;
			}
			else if (weekRb.isSelected()){
				shipping = 12;
			}
			else if(standardRb.isSelected()){
				shipping = 5;
			}
			//calculate and change total label
			double total = itemCost*quantity+(itemCost*quantity*taxRate)+shipping;
			totalCostLbl.setText(NumberFormat.getCurrencyInstance().format(total));
		});
		//reset button
		resetBtn.setOnAction(e -> {
			itemFld.setText("");
			priceFld.setText("");
			quantityFld.setText("");
			taxChk.setSelected(false);
			dayRb.setSelected(false);
			weekRb.setSelected(false);
			standardRb.setSelected(false);
			totalCostLbl.setText("$0.00");
		});
		
		//construct the scene
		Scene scene = new Scene(panetone);
		mainStage.setTitle("Orinoco Calcu-Later");
		mainStage.setScene(scene);
		mainStage.show();
	}
	
	public static void main(String[] args) {
		//make the window happen
		launch(args);
	}


}
