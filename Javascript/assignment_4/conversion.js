/*
Daniel Bruce
2/9/2022
This program allows the user to convert between units of measurement by
choosing units from a menu and entering their value.
*/
const readlineSync = require ("readline-sync");
//import * as conversion from ".conversionutils";
const conversionUtils = require ("./conversionutils");
//console.log(conversion(10).acres_to_sqft());
let escape = 0;
//loop unless they want to quit
console.log("Unit Conversion Calculator");
while (escape == 0){
    //this is the "menu"
    console.log("Choose your unit conversion method by entering its number:");
    console.log("(1)Feet -> Meters       (2) Meters -> Feet");
    console.log("(3)Kilometers -> Miles  (4) Miles -> Kilometers");
    console.log("(5)Square Feet -> Acres (6) Acres -> Square Feet");
    console.log("(7)Gallons -> Cups      (8) Pounds -> Kilograms");
    console.log("(0)Exit Program");
    //get conversion type
    let convertChoice = parseInt(readlineSync.question("Enter your selection: "));
    //validate input and handle program exit procedure
    if (convertChoice > 8 || convertChoice < 1){
        if (convertChoice == 0){
            escape = 1;
        }
        else{
            console.log("Invalid input! Please enter one of the numbers from the menu.");
        }
        continue;
    }
    let convertValue = parseInt(readlineSync.question("Enter the value you are converting: "));
    var conversionBox = new conversionUtils.conversion(convertValue);
    //use a function based on the user's selection
    switch (convertValue != null){
        case convertChoice == 1:
            console.log("Your converted value is: " + conversionBox.foot_to_meter() + " meters.");
            break;
        case convertChoice == 2:
            console.log("Your converted value is: " + conversionBox.meter_to_foot() + " feet.");
            break;
        case convertChoice == 3:
            console.log("Your converted value is: " + conversionBox.kilo_to_mile() + " miles.");
            break;
        case convertChoice == 4:
            console.log("Your converted value is: " + conversionBox.mile_to_kilo() + " kilometers.");
            break;
        case convertChoice == 5:
            console.log("Your converted value is: " + conversionBox.sqft_to_acres() + " acres.");
            break;
        case convertChoice == 6:
            console.log("Your converted value is: " + conversionBox.acres_to_sqft() + " square feet.");
            break;
        case convertChoice == 7:
            console.log("Your converted value is: " + conversionBox.gallon_to_cup() + " cups.");
            break;  
        case convertChoice == 8:
            console.log("Your converted value is: " + conversionBox.pounds_to_kg() + " kilograms.");
            break;
        default://shouldn't happen
            console.log("Unknown Error!");
            break;  
    }
}
//let them know they left the program
console.log("Exiting program...");
