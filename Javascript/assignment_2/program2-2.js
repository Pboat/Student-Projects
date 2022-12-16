/*
Daniel Bruce
1/17/2022
Have the user see if they can win the lottery
*/
//introduce program
var readlineSync = require('readline-sync');
console.log('Welcome to the lottery! Enter a 3 digit number and see if you\'ll win.');
//used to "close" the program
let stay = 'y';
do{
    //generate numbers individually and turn it into a string to maintain 0's in values below 100
    let digitOne = Math.floor(Math.random()*10);
    let digitTwo = Math.floor(Math.random()*10);
    let digitThree = Math.floor(Math.random()*10);
    let lotteryNum = digitOne.toString()+digitTwo.toString()+digitThree.toString();
    console.log(lotteryNum);
    let guess = readlineSync.question('Enter your number guess: ');
    while (guess.length <3){ //add a prefixal 0 if the input number is less than 3 digits long
        guess = '0' + guess;
        
    }
    //check if they won
    if (lotteryNum == guess){ //10000
        console.log('Congratulations! You won the grand prize, \$10,000!');
    }
    else if(guess.search(lotteryNum[0])>=0 && guess.search(lotteryNum[1])>=0 && guess.search(lotteryNum[2])>=0){//3000
        console.log('Your numbers matched, but in a different order. You won \$3,000!');
    }
    else if (guess.includes(lotteryNum[0]) || guess.includes(lotteryNum[1]) || guess.includes(lotteryNum[2])){//1000
        console.log('One of your numbers matched, you won \$1,000!');
    }
    else{//no match
        console.log('Oh No! You didn\'t win. Please try again.');
    }
    stay = readlineSync.question('Try again? (y/n): ');
} while(stay == 'y' || stay == 'Y');
console.log('Thanks for playing!');