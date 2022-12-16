/*
Daniel Bruce
1/17/2022
Enter test grades, and get the student with the highest score (I'm assuming you want no arrays)
*/

const readlineSync = require('readline-sync');//the classic readline-sync import
console.log('Enter your test scores.');
let student = 'RealMcActualName';
let score = -1;
let highScore = 0;
let highStudent = '';
//find the highest score
let count = parseInt(readlineSync.question('How many students took the test?: '));
for(count;count>0;count--){
    student = readlineSync.question('Enter a student\'s name: ');
    score = parseInt(readlineSync.question('Enter their score: '));
    if (score > highScore){
        highScore = score;
        highStudent = student;
    }
}
//display the results
console.log('The student with the highest score was ' + highStudent +', with a score of ' + highScore + '.');