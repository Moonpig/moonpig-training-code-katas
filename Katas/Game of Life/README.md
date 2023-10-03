# Game of Life

The Game of Life is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. One interacts with the Game of Life by creating an initial state and observing how each generation evolves.

## Rules of the Game

You start with a two-dimensional grid of cells, where each cell is either alive or dead. This is the initial state or ‘seed’ of the system.
When calculating the next generation of the grid, follow these rules:

1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
2. Any live cell with more than three live neighbours dies, as if by overcrowding.
3. Any live cell with two or three live neighbours lives on to the next generation.
4. Any dead cell with exactly three live neighbours becomes a live cell.

A neighbour is any of the eight cells immeadiately surrounding a cell, including diagonals.

A generation is created by applying all of the above rules to each and every cell in the seed. Births and deaths occur simultaneously. This process is called a tick. We can run multiple ticks by treating the output of one generation as the input for the next.

## The Task

You should write a program that accepts an initial arbitrary grid of cells, runs a single tick on the grid, and outputs a grid representing the next generation.

In this version of the problem:

1. The grid is finite and no life can exist off the edges.
2. You only need to calculate a single tick.
3. You do not need to build any UI or user-facing parts of the system.
4. You may pick any convenient way of representing the input/output grid.

This website might be helpful in visualising a tick: https://playgameoflife.com/.
