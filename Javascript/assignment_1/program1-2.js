/*
Daniel Bruce
1/13/2022
Prof. Tillman runs fast
*/
var lapSec = 55*60 + 30;
var distKM = 10;
var kmMileConversionFactor = 0.6214;
//calc speed in MPH
var resultMPH = distKM/lapSec * (60**2) * kmMileConversionFactor;
console.log(resultMPH + ' MPH');