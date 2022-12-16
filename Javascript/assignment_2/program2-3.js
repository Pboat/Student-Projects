/*
Daniel Bruce
1/17/2022
Get the average of all non-zero numbers
*/
const readlineSync = require('readline-sync');
let countPositive = 0;
let countNegative = 0; 
let numero = 0;
let sum = 0;
console.log('Enter numbers until you get bored')
//get numbers
do{
    numero = parseInt(readlineSync.question('Enter zero to stop, otherwise, enter an integer: '));
    //get the number of numbers, positive and negative
    if (numero > 0){
        countPositive++;
    }
    else if (numero < 0){
        countNegative++;
    }
    sum += numero;
}while(numero);
//display stats
console.log('Total: ' + sum);
console.log('Average: '+ (sum/(countPositive+countNegative)));
