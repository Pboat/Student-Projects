/*
Daniel Bruce
1/26/2022
this program lets you enter 10 integers, 
and reads them back out in reverse order
*/

const readlineSync = require ('readline-sync');
console.log('Enter 10 numbers and I\'ll reverse \'em for you.');
const intHold = new Array(10);

//get the numbers
for (let x = 0; intHold.length>(x); x++){
    intHold[x] = parseInt(readlineSync.question('Enter a number: ')); 
                //parse int to make sure it's an int
}

console.log('Your numbers in reverse order are:');
//read them back
for (let y = intHold.length-1; y > -1; y--){
    console.log(intHold[y]);
}