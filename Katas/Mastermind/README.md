# Mastermind

Write a simple terminal app to allow a user play a round of mastermind. 
Mastermind is a game where a player has to break a colour code. 
The code is made up of 4 colours out of 6 available colours. 

The available colours are:
`Orange (O), Pink (P), Yellow (Y), Green (G), White (W), and Black (B)`

Code example: 
`OYGW` 

### Rules:
* The computer generates a code (repeated colours are allowed)
* User guesses code 
* Computer indicates correctnes of guessed code with green and yellow indicators
    * 1 green indicator for each correct colour in the correct place
    * 1 yellow indicator for each correct colour in the wrong place
* The user has 8 guesses to crack the code
* The place in which the correctness indicators are placed do *NOT* relate to the places of the guess
* If the code is cracked the game will show a win message
* If the user has no guesses left the game will show a lose message and reveal the code
* If the user has not cracked the code but has guesses left the remaining guesses are shown

### Examples

Orange in the right place, all others in the wrong place
```
Code:   OPYG
Guess:  OGPY
Response: GYYY
```

Orange and Pink in the wrong place, White and Black not in code
```
Code:   OPYG
Guess:  WBOP
Response: YY
```

Pink in right place, Green in wrong place, White and Black not in code
```
Code:   OPYG
Guess:  WPGB
Response: GY
```
