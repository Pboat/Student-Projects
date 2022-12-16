package bruce15;
	
import javafx.application.Application;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.shape.Circle;
import javafx.scene.paint.*;
import javafx.scene.layout.*;
import javafx.geometry.*;
import javafx.event.*;

/* Daniel Bruce
 * 2437650
 * 
 * This program lets you move a circle using 4 buttons
*/


public class BallMover extends Application {
	//constants
	final int left = 0;
	final int up = 1;
	final int down = 2;
	final int right = 3;
	private CirclePane ballPane = new CirclePane();
	
	@Override
	//the meat of the program
	public void start(Stage mainStage) {
		
		//make panes
		
		//StackPane paneCake = new StackPane();
		HBox rest = new HBox(3);
		BorderPane board = new BorderPane();
		board.setCenter(ballPane);
		board.setBottom(rest);
		
		//add things to panes
		//buttons
		Button leftBtn = new Button("Left");
		rest.getChildren().add(leftBtn);
		Button upBtn = new Button("Up");
		rest.getChildren().add(upBtn);
		Button downBtn = new Button("Down");
		rest.getChildren().add(downBtn);
		Button rightBtn = new Button("Right");
		rest.getChildren().add(rightBtn);
		rest.setAlignment(Pos.CENTER);
		//circle
		
		
		//make the handlers listen
		leftBtn.setOnAction(new MoveLeftHandler());
		upBtn.setOnAction(new MoveUpHandler());
		downBtn.setOnAction(new MoveDownHandler());
		rightBtn.setOnAction(new MoveRightHandler());
		
		
		//display scene
		Scene scene = new Scene(board,200,150);
		mainStage.setTitle("ball");
		mainStage.setScene(scene);
		mainStage.show();
	}
	//handlers
	//left
	class MoveLeftHandler implements EventHandler<ActionEvent>{
		public void handle(ActionEvent e) {
			ballPane.move(left);
		}
	}
	//up
	class MoveUpHandler implements EventHandler<ActionEvent>{
		public void handle(ActionEvent e) {
			ballPane.move(up);
		}
	}
	//down
	class MoveDownHandler implements EventHandler<ActionEvent>{
		public void handle(ActionEvent e) {
			ballPane.move(down);
		}
	}
	//right
	class MoveRightHandler implements EventHandler<ActionEvent>{
		public void handle(ActionEvent e) {
			ballPane.move(right);
		}
	}
	//launcher
	public static void main(String[] args) {
		launch(args);
	}
}

class CirclePane extends Pane{
	private Circle ball = new Circle(20);
	
	public CirclePane() {
	ball.setStroke(Color.BLACK);
	ball.setFill(Color.CHARTREUSE);
	ball.setCenterX(ball.getRadius());
	ball.setCenterY(ball.getRadius());
	getChildren().add(ball);
	}
	
	public void move(int dir) {
		//move ball
		switch (dir) {
		case 0: //left
			ball.setCenterX(ball.getCenterX()-5);
			break;
		case 1: //up
			ball.setCenterY(ball.getCenterY()-5);
			break;
		case 2: //down
			ball.setCenterY(ball.getCenterY()+5);
			break;
		case 3: //right
			ball.setCenterX(ball.getCenterX()+5);
			break;
		}
		//keep ball from going past bounds
		if ( ball.getCenterY() > getHeight() - ball.getRadius() ) {
			ball.setCenterY(getHeight() - ball.getRadius());
		}
		if (ball.getCenterY() < ball.getRadius()) {
			ball.setCenterY( ball.getRadius());
		}
		if (ball.getCenterX() > getWidth() - ball.getRadius()) {
			ball.setCenterX(getHeight() - ball.getRadius());
		}
		if (ball.getCenterX() < ball.getRadius()) {
			ball.setCenterX(ball.getRadius());
		}
		
	}
}
