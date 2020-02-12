# Go Counting
In the game of go points are gained by completely encircling empty intersections with your stones.  
The encircled intersections of a player are known as its territory.

Multiple empty intersections may be encircled at once and for encircling only horizontal and vertical neighbours count. 
Empty spaces represent empty intersections.

**Examples**
The dots on empty spaces are just to make the examples easier to comprehend.
```
+-----+
|..OX.|
|..OX.|
|.OX..|
|OXX..|
|XX...|
+-----+
X = 9 points
O = 5 points
```
It is also possible for an enclosed territory to be completely surrounded by the enemy.
```
+-------+
|.XXXXX.|
|.XOOOX.|
|.XO.OX.|
|.XO.OX.|
|.XO.OX.|
|.XOOOX.|
|.XXXXX.|
+-------+
X = 14 points (territory on the outside)
O = 3 points (territory in the middle)
```

Write a program that determines the territory of each player.  
You may assume that any stones that have been stranded in enemy territory have already been taken off the board.

