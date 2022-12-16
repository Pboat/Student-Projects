/*
Daniel Bruce
1/13/2022
do the algebra with Cramer's rule
*/
var a = 3.4;
var b = 50.2;
var e = 44.5;
var c = 2.1;
var d = .55;
var f = 5.9;
//use cramer's rule to get the missing variables
var x = (e*d - b*f)/(a*d - b*c);
var y = (a*f - e*c)/(a*d - b*c);
//print the results, formated as coordinates
console.log('(' + x + ',' + y + ')');