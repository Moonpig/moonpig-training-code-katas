# Game of Life

The Game of Life is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. One interacts with the Game of Life by creating an initial state and observing how each generation evolves.

## Rules of the Game

You start with a two-dimensional grid of cells, where each cell is either alive or dead. This is the initial state or ‘seed’ of the system.
When calculating the next generation of the grid, follow these rules:

1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
2. Any live cell with more than three live neighbours dies, as if by overcrowding.
3. Any live cell with two or three live neighbours lives on to the next generation.
4. Any dead cell with exactly three live neighbours becomes a live cell.

You should write a program that can accept an initial arbitrary grid of cells, and will output a similar grid showing
the next generation. A generation is created by applying all the above rules to every cell in the seed; births and
deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick.
Each generation is a pure function of the preceding one.

## Other requirements

In this version of the problem:

1. The grid is finite and no life can exist off the edges.
2. You start with a two dimensional grid of cells, where each cell is either alive or dead.
3. Only one tick is needed.
4. Neighbours can be diagonal to each other.

This website might be helpful in visualising a tick: https://playgameoflife.com/.
