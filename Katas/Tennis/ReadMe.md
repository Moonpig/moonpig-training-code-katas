# Tennis Refactoring Kata

Imagine you work for a consultancy company, and one of your colleagues has been doing some work for the Tennis Society. The contract is for 10 hours billable work, and your colleague has spent 8.5 hours working on it. Unfortunately he has now fallen ill. He says he has completed the work, and the tests all pass. Your boss has asked you to take over from him. She wants you to spend an hour or so on the code so she can bill the client for the full 10 hours. She instructs you to tidy up the code a little and perhaps make some notes so you can give your colleague some feedback on his chosen design. You should also prepare to talk to your boss about the value of this refactoring work, over and above the extra billable hours.

There are three versions of this refactoring kata, each with their own design smells and challenges. I suggest you start with the first one, with the class "TennisGame1". The test suite provided is fairly comprehensive, and fast to run. 

Original src and starter code: https://github.com/emilybache/Tennis-Refactoring-Kata

## Rules

You can read more about Tennis scores [here](https://en.wikipedia.org/wiki/Tennis#Scoring) which are summarised below:

1. A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
2. The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as "Love", "Fifteen", "Thirty", and "Forty" respectively.
3. If at least three points have been scored by each player, and the scores are equal, the score is "Deuce".
4. If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is "Advantage" for the player in the lead.

You should not need to change the tests, only run them often as you refactor.

Only the score is reported for the current game. Sets and Matches are out of scope.

### Refactoring techniques:

[Object Calisthenics](https://williamdurand.fr/2013/06/03/object-calisthenics/)

[Other techniques](https://refactoring.guru/refactoring/techniques)

### Solutions

[A solution in Java ](https://github.com/ValentinaServile/Tennis-Refactoring-Kata-Java/tree/master/src/main/java)

## Learnings

Weds Oct 9th 2019:

Represented scores such as Deuce and Advantage as objects who know how to print themselves.

Refactoring following the Calisthenics in order was a bit slow, since you would normally do a few Calisthenics refactorings in one go rather than one after the other. eg: One Level Of Indentation Per Method can be done on the same piece of code while applying another refactoring.

Refactorings could be planned and prioritised for better results.