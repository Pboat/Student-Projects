/*
Daniel Bruce
1/26/2022
Enter scores from students, and devise a grading scale
based on their scores.
*/
const readlineSync = require('readline-sync');
console.log('Enter the class\'s test scores, and get their grades based on the best score.');
//vars
const reportCard = new Array();
let bestScore = 0;
//get the number of students
let studentCount = parseInt(readlineSync.question('How many students are there? : '));
//get test scores
for (let x = 0; x < studentCount; x++){
    let input = parseInt(readlineSync.question('Enter a test score: '));
    if (input > bestScore){//find best
        bestScore = input;
    }
    reportCard.push(input);
}
//determine grade for each student
for (let x = 0; x < studentCount; x++){
    //prepare the resuls string
    let grade = 'Student ' + (x+1) + '\'s score was ' + reportCard[x] + ' and they got a';
    //find the difference and use a switch to determine the proper grade
    let difference = bestScore - reportCard[x];
    switch (difference != null){ //should always pass
        case difference <= 10:
            grade += 'n A.';
            break;
        case difference > 10 && difference <=20:
            grade += ' B.';
            break;
        case difference > 20 && difference <= 30:
            grade += ' C.';
            break;
        case difference > 30 && difference <=40:
            grade += ' D.';
            break;
        case difference > 40:
            grade += 'n F.';
            break;
        default://this one shouldn't happen
            grade += 'n error.'
            break;
    }
    //display results
    console.log(grade);
}


