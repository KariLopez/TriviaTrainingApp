# TriviaTrainingApp

## Goal
The goal is to create an application that others will be able to use in order to help
improve their trivia skills.  

## Acceptance Criteria
* A user can view questions.
* Questions with their multiple choice options must be displayed one at a time.
* Questions should not repeat in a round.
* A user can select only 1 answer out of the 4 possible answers.
* The correct answer must be revealed after a user has submitted their answer
* A user can see the score they received at the end of the round

## Assumptions
* A round of trivia has 10 Questions
* All questions are multiple-choice questions
* Your score does not need to update in real time
* Results can update on form submit, button click, or any interaction you choose 

## To start 
* Download Visual Studio https://visualstudio.microsoft.com/downloads/
* Restore packages
  * Navigate to Tools>NugetPacketManager and click when prompted to restore packages
* Start Program
* Follow Propmpts

## Dependencies
* Newtonsoft.Json.Linq - for parsing JSON
* System.IO - for reading JSON file
* XUnit classes - for running tests
* JSON File - It is a part of the project and is set to copy to directory, wihtout it the program will not be able to run through any of the trivia

## Running Tests
Open Test Explorer in Visual Studio
Click Run All 


## Additional Features
* Method to add more questions extending Question Class 
* Alternate order of questions presented while not repeating questions 


## Known issues
* each round will only go through questions in order of index so currently you can only play 2 rounds and then game ends
* User can submit an answer that is not in the index of choices 
  * User can submit 9 when only 3 choices are presented and it will come back as incorrect but won't ask for a valid input within range

