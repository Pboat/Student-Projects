package bruce14;
	
import javafx.application.Application;
import javafx.geometry.*;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.layout.GridPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.*;
import javafx.scene.Group;


/* Daniel Bruce
 * 2437650
 * 
 * This program draws 3 colored shapes diagonally
*/

public class ShapeTest extends Application {
	@Override
	public void start(Stage mainStage) {
		
		//a digital frontier
		GridPane theGrid = new GridPane();
		theGrid.setAlignment(Pos.CENTER);
		theGrid.setPadding(new Insets(15,15,15,15));
		theGrid.setHgap(5);
		theGrid.setVgap(5);
		
		//put things in the grid\\
		//rectangle
		Rectangle spongeBob = new Rectangle (0,0,30,50);
		spongeBob.setStroke(Color.BLACK);
		spongeBob.setFill(new Color(0.9,0.8,0,1));
		theGrid.add(spongeBob, 0, 0);
		//circle
		Circle pizza = new Circle();
		pizza.setRadius(49);
		pizza.setStroke(new Color(0.9,0.5,0,1));
		pizza.setStrokeWidth(4);
		pizza.setFill(new Color(0.97,0.92,0.75,1));
		theGrid.add(pizza, 1, 1);
		//cross
		Group theRelic = new Group();
		Line vert = new Line(50,50,50,0);
		Line horiz = new Line (65,15,35,15);
		vert.setStroke(Color.DARKBLUE);
		horiz.setStroke(Color.DARKBLUE);
		vert.setStrokeWidth(15);
		horiz.setStrokeWidth(15);
		theRelic.getChildren().add(vert);
		theRelic.getChildren().add(horiz);
		theGrid.add(theRelic, 2, 2);
		//set horizontal alignment
		GridPane.setHalignment(spongeBob,HPos.LEFT);
		GridPane.setHalignment(pizza,HPos.CENTER);
		GridPane.setHalignment(theRelic,HPos.RIGHT);
		//set vertical alignment
		GridPane.setValignment(spongeBob,VPos.TOP);
		GridPane.setValignment(pizza,VPos.CENTER);
		GridPane.setValignment(theRelic,VPos.BOTTOM);
		//making a scene here
		Scene scene = new Scene(theGrid);
		mainStage.setTitle("Fun With Shapes!");
		mainStage.setScene(scene);
		mainStage.show();
	}
	//launch the program
	public static void main(String[] args) {
		launch(args);
	}
}
