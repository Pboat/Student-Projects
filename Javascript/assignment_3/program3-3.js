/*
Daniel Bruce
1/26/2022
This program lets you enter scores,
and gives you the average, as well as the number of scores
below average and equal to average
*/
const readlineSync = require('readline-sync');
console.log('Enter your scores, and get the average score and more!');
//vars
const scoreCard = new Array();
let average = 0;
let greatScores = 0;
let poorScores = 0;
let averageScores = 0;
let input = 0;
//get the scores
for(let x = 0; input >= 0; x++){
    input = parseInt(readlineSync.question('Enter a score:'));
    if (input>=0){
        scoreCard.push(input);
        average += scoreCard[x];
    }
}
//now that we have all of the scores, finish averaging
average /=scoreCard.length;
//find scores above and below average
for (let y = 0; y < scoreCard.length; y++){
    if (scoreCard[y] > average){
        greatScores++;
    }
    else if (scoreCard[y] < average){
        poorScores++;
    }
    else { 
        averageScores++;
    }
}
//display results
console.log('The average score was: ' + average);
console.log('There were ' + greatScores + ' scores that were above average, while ' + poorScores + ' were below average.');
if (averageScores > 0){ //rare condition, doesn't always show up
    console.log('There\'s even ' + averageScores + ' that\'s EXACTLY the same as the average!');
}
