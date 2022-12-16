/*
Daniel Bruce
1/26/2022
This program lets you enter numbers, 
and keeps a running tally of how often each number shows up
*/

const readlineSync = require ('readline-sync');
console.log('Enter some numbers, and I\'ll count them. enter \"0\" to stop');

const numTally = new Array();
do{
    //ask for input
    input = parseInt(readlineSync.question('Enter a number between 1 and 100:'));
    if (input == 0){ //end loop if 0
        break;
    }
    else if (input > 100 || input < 0){ //start over without changing anything if incorrect value is entered
        console.log('Invalid input! Please enter a number between 1 and 100, or enter 0 to stop.');
        continue;
    }
    if (numTally.length == 0){//adds the first number to the array
        numTally.push([input,1]); 
    }
    else{//adds subsequent numbers to the array and increments appearance count
        for(let x = 0;x<numTally.length;x++){
            if (input == numTally[x][0]){
                numTally[x][1]++;
            }
            else if (x == numTally.length-1){//if the array's end has been reached, check for duplicates
                let addVal = true;
                for(let y = 0;y<numTally.length;y++){
                    if (input == numTally[y][0]){
                        addVal = false;
                        break;
                    }     
                }
                if (addVal){
                    numTally.push([input,0]); //add a new number if no dupes
                }
            }
        }
       
    }
    //count how many times the number appeared
}while(input!=0); //redundant condition: we want to break at a specific point so that 0 isn't counted
//read off the tally
for(let z = 0;z<numTally.length;z++){
    console.log(numTally[z][0] + ' showed up '+numTally[z][1] + ' times.');
}