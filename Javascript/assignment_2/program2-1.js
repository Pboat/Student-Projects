/*
Daniel Bruce
1/17/2022
Solve for Cramer's rule using user input
*/
var readlineSync = require('readline-sync');
let stay = 'y';
do{
	//initial instructions
	console.log ('Solve for x and y using Cramer\'s rule!');
	console.log ('Solving using Cramer\'s rule requires 2 linear equations.');
	console.log ('The 1st equation would be:ax+by = e');
	console.log ('The 2nd equation would be:cx+dy = f');
	//console.log ();
	//enter variables
	var a = parseInt(readlineSync.question('Enter a: '));
	var b = parseInt(readlineSync.question('Enter b: '));
	var c = parseInt(readlineSync.question('Enter c: '));
	var d = parseInt(readlineSync.question('Enter d: '));
	var e = parseInt(readlineSync.question('Enter e: '));
	var f = parseInt(readlineSync.question('Enter f: '));
	//check to see if there's a divide by 0 error
	if (a*d-b*c == 0 ){
		console.log('Impossible Solution!');
	}
	else{
		//use Cramer's rule
		var x = (e*d - b*f)/(a*d - b*c);
		var y = (a*f - e*c)/(a*d - b*c);
		console.log('x = ' + x);
		console.log('y = ' + y);
	}
	do{
		stay = readlineSync.question('Would you like to solve for another set?(y/n)');
	} while(stay !== 'n' && stay !== 'N' && stay !=='y' && stay !== 'Y');
}while(stay =='y' || stay == 'Y');
		
//}