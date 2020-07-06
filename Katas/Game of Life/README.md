# Game of Life

The Game of Life is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. 
One interacts with the Game of Life by creating an initial configuration and observing how it evolves.

# Rules of the Game

You start with a two dimensional grid of cells, where each cell is either alive or dead. In this version of the problem, the grid is finite, and no life can exist off the edges. When calcuating the next generation of the grid, follow these rules:

```
   1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
   2. Any live cell with more than three live neighbours dies, as if by overcrowding.
   3. Any live cell with two or three live neighbours lives on to the next generation.
   4. Any dead cell with exactly three live neighbours becomes a live cell.
```

Each cell (C) has 8 neighbours(N):

```
~~~~~
~NNN~
~NCN~
~NNN~
~~~~~
```

You should write a program that can accept an initial arbitrary representation of the game state, and will return the next generation.

The initial pattern constitutes the seed of the system. The first generation is created by applying the above rules simultaneously to every cell in the seed; births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick. Each generation is a pure function of the preceding one. The rules continue to be applied repeatedly to create further generations.
