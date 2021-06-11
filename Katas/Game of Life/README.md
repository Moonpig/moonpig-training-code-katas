# Game of Life

The Game of Life is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. 
One interacts with the Game of Life by creating an initial configuration and observing how it evolves.

# Rules of the Game

A square grid contains cells that are either alive or dead. The behaviour of each cell is dependent only on the state of its eight immediate neighbours, according to the following rules:

```
   1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
   2. Any live cell with more than three live neighbours dies, as if by overcrowding.
   3. Any live cell with two or three live neighbours lives on to the next generation.
   4. Any dead cell with exactly three live neighbours becomes a live cell.
```

We start with a pattern on the grid (generation 0) and we apply the rules simultaneously on all cells. This action results in a new pattern (generation 1). We then apply the rules again on all the cells, which creates another pattern (generation 2), and so on, and so on.

In general, a cell (C) has 8 neighbours (N):

```
| ~ | ~ | ~ | ~ | ~ | 
| ~ | ~ | ~ | ~ | ~ |
| ~ | N | N | N | ~ |
| ~ | N | C | N | ~ |
| ~ | N | N | N | ~ |
| ~ | ~ | ~ | ~ | ~ |
| ~ | ~ | ~ | ~ | ~ |
```
Note that edge cells and corner cells have less neighbours as there are no cells outside of the grid.
Note that in this version of the problem, the grid is finite, and no life can exist off the edges.

# The Task

You should write a program that can accept an initial arbitrary representation of the game state, and will return the next generation.

The initial pattern constitutes the seed of the system. The first generation is created by applying the above rules simultaneously to every cell in the seed; births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick. Each generation is a pure function of the preceding one. The rules continue to be applied repeatedly to create further generations.
