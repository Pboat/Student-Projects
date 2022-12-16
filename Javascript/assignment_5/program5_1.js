/*
Daniel Bruce
2/22/2022 (neat)
This program makes use of classes to simulate the growth of an orange tree
*/

class OrangeTree{
    constructor(finalAge){
        this._height = 1;
        this._age = 0;
        this._finalAge = finalAge;
        this._oranges = 0;
        this._dead = false;
    }
    //changes tree based on age
    passYear(){
        //only age a living tree
        if (this._age < this._finalAge){
            this._age += 1;
            //grow the tree logarithmically based on age
            this._height = Math.round(Math.log2(this._age + 1) * 5);
            //orange generation determined by age
            if (this._age >= 2 && this._age <= 5){
                this._oranges = Math.round(10 + this._age + (Math.random()*this._age));
            }
            else if (this._age > 5){
                this._oranges = Math.round(20 + (Math.random()*6));
            }
        }
        else{
            this._dead = true;
        }
    }
    //this is just a getter????
    countOrange(){
        return this._oranges
    }
    //try to pick an orange
    pickOrange(){
        let orngStr = "There's no more oranges! Come back next year."
        if (this._oranges > 0){
            this._oranges -= 1;
            orngStr = "You picked a juicy orange."
        }
        return orngStr;
    }
    //getters
    get height(){
        return this._height;
    }
    get age(){
        return this._age;
    }
    get dead(){
        return this._dead;
    }
}

//main program starts here
const readlineSync = require("readline-sync");
let again = true;//main escape val

do{
    //get the user to "plant" a tree
    console.log("Let's grown an orange tree!");
    console.log("Orange trees need special attention and care, or they'll die!");
    console.log("How many years will you take care of this tree?");
    let careYears = parseInt(readlineSync.question("Years:"));
    const naranja = new OrangeTree(careYears);
    console.log("Congratulations on your new orange tree!");
    //main tree care loop
    while (!naranja.dead){
        //prompt them to make a decision
        console.log("You have an orange tree that is " + naranja.age + " years old. What will you do?");
        console.log("(1)Pick an orange | (2)Wait a year | (3)Check tree");
        let treeMenu = parseInt(readlineSync.question("Enter a number:"));
        switch (treeMenu){
            case 1:
                console.log(naranja.pickOrange());
                break;
            case 2:
                naranja.passYear();
                break;
            case 3:
                console.log("Its height is " + naranja.height +" ft tall and it has " + naranja.countOrange() + " oranges hanging on it.");
                break;
            default:
                console.log("Please enter a number from the menu.");
                break;
        }
    }
    //tree's dead, tell 'em about it at the end, and ask if they want to go again.
    console.log("After " + naranja.age + " years, your orange tree has died!");
    console.log("It grew to a height of " + naranja.height +" ft and had " + naranja.countOrange() + " oranges left on it.");
    let escStr = readlineSync.question("Would you like to continue? (y/n)");
    //program ending condition
    if(escStr == "n"){
        again = false;
    }
}while(again);
