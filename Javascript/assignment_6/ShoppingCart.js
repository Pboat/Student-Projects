/*
Daniel Bruce
3/2/2022
This program verifies a user's email address and credit card number
*/
class ShoppingCart{
    //constructor
    constructor(){
        this.credit = "0009000900090009"
        this.email = ""
    }
    //the whole process is done through here
    Checkout(){
        //vars & consts
        const readlineSync = require("readline-sync");
        const emailPattern = /\S{1,}@{1}\S{1,}\.{1}\S{1,3}/  //at least one char, @, at least one char, period, at most 3 chars
        let input = "";
        //get a valid e-mail address
        do{
            input = readlineSync.question("Please enter your e-mail address: ");
            //tell them they got it wrong if it's formated incorrectly
            if (!emailPattern.test(input)){
                console.log("Invalid e-mail address!");
            }
        }while(!emailPattern.test(input))
        this.email = input;

        const creditPattern = /\d{16}/ // only 16 digits
        //get valid credit card number
        do{
            input = readlineSync.question("Please enter your credit card number: ");
            if (!creditPattern.test(input)){
                console.log("Invalid card number!");
            }
        }while(!creditPattern.test(input))
        this.credit = input;
        console.log("Thank you for shopping with us!");
        console.log("Your order has been processed and will arrive within 5-10 days.");
    }

}

//main program
console.log("To proceed with your purchase, please enter the following information.");
let mercaMart = new ShoppingCart();
mercaMart.Checkout();