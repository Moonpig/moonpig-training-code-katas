# Code Kata: Hunt the Wumpus
Hunt the Wumpus is a text-based adventure game where you are an adventurer in a 
dangerous cave, trying to hunt down the notorious Wumpus. 

Some history of the game, orignally invented by Gregory Yob in 1972, can be found [here](https://en.wikipedia.org/wiki/Hunt_the_Wumpus).

# Rules of the game

## Rooms
You play in a cave composed of rooms, each 'room' may be:
* Empty
* Have a bottomless pit in it. Moving into this room causes you to fall into the pit and die (losing the game)
* Have a colony of noisy bats in it, who will immediately carry you to a random other room
* Have a previous hunter's crooked arrow in it, which you pick up
* Have the fearsome, hungry, unbathed Wumpus in it, who will eat you (you lose the game)

Traditionally there is two colonies of bats and two bottomless pits; and one lost arrow and one (thankfully, only) Wumpus.

The Cave is composed of twenty rooms, each of which is connected to three other rooms - modeled on the vertices of a Dodecahedron. There is no need to graphically display the layout of the rooms.

## Environment
In each room you may:
* Feel a breeze nearby, indicating there is a bottomless pit in a room adjacent to this room
* Hear bats nearby
* Smell a Wumpus nearby

## Actions
In each room you may:
* Move to one of the three adjacent rooms
* Fire a crooked arrow into an adjacent room

## Arrows
* An arrow kills a Wumpus if fired into its room (you win the game)
* You start with a quiver of five arrows
* Each arrow you fire is lost (it is dark in the cave)
* Bats are too swift to be harmed by arrows
* Arrows have no effect on the bottomless pit (obviously!)
* If you find a dropped arrow, you put it in your quiver
* If you fire an arrow into a room adject to the Wumpus it is startled 

### Startled Wumpus
A startled Wumpus may stay where it is, or it may move to a random room in the cave. If the Wumpus moves then it makes enough noise that the player will hear it move - though of course they will not know where the Wumpus has hidden!

Good hunting!

## Learnings

### Wed 20th Nov 2019

* Tricky to map caves to appropriate data structure
* Should the room know about the player or should the player know which room they are in?
* How do we keep track of rooms you've previously entered?
* Naming - choosing domain names (eg: doors) vs names good for programming   