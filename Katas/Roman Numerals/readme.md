## Roman Numerals

Write a function which converts an integer number into its Roman numeral equivalent.

Here is a table with some examples inputs and the expected outputs: 

| Number  | 1   | 2   | 3   | 4   | 5   | 6   | 7   | 8   | 9   |
|:--------|:----|:----|:----|:----|:----|:----|:----|:----|:----|
| Numeral | I   | II  | III | IV  | V   | VI  | VII | VIII| IX  |

| Number  | 10  | 20  | 30  | 40  | 50  | 60  | 70  | 80  | 90  |    
|:--------|:----|:----|:----|:----|:----|:----|:----|:----|:----|
| Numeral | X   | XX  | XXX | XL  | L   | LX  | LXX | LXXX| XC  |

| Number  | 100 | 500 | 1000|
|:--------|:----|:----|:----|
| Numeral | C   | D   | M   |

All other numbers follow the same patterns, for example 973 would be CMLXXIII.

### Getting Started

Your implementation should consist of a function similar to:

```fun convert(amount: Int): String```
