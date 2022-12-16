package bruce14;


import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.text.*;
import javafx.scene.layout.Pane;
//import javafx.



/* Daniel Bruce
 * 2437650
 * 
 * This program displays the funny emoji
*/


public class FunnyEmoji extends Application {
	
	
	public void start(Stage mainStage) {
		
		//make the funny emoji
		Pane pain = new Pane();
		pain.setPadding(new Insets(15,15,15,15));
		//String emoji = new String(Character.toChars(0x0001F47B));
		Text funnyEmoji = new Text(20,400,"\uD83D\uDC7B");
		funnyEmoji.setFont(Font.font("Calibri",400));
		pain.getChildren().add(funnyEmoji);
		
		
		//prep display
		Scene scene = new Scene(pain);
		mainStage.setTitle("boo ha ha got you");
		mainStage.setScene(scene);
		mainStage.show();
	}
	
	public static void main(String[] args) {
		//launch it
		launch(args);
	}

}
