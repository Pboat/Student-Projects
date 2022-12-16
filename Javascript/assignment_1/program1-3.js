/*
Daniel Bruce
1/13/2022
Population go up, but how much??????
*/
var timeFrame = 60*60*24*365*10;//this should come out to 10 years (assuming no leap years as that would complicate this too much)
var births = timeFrame/7; //timeframe is based in seconds, so simply divide by 7
var deaths = timeFrame/30;
var immigration = timeFrame/60;
//find the population
var population = 412000000 + births + immigration - deaths;
console.log(population);