# Fun With Befunge
Befunge is a two-dimensional esoteric programming language invented in 1993 by Chris Pressey with the goal of being as difficult to compile as possible. We will implement a simplified version which only deals with numbers and does not allow programs to self-modify.

A Befunge program is laid out on a two-dimensional grid of cells, each containing one ASCII character representing an instruction. Execution proceeds by means of a pointer which begins at the top-left cell and is initially travelling to the right. As it encounters instructions, they are executed. The pointer’s direction of travel can be modified by using the appropriate instructions. The only data storage available is a single stack which stores an integer which can pushed to and popped from using the relevant instructions.

### Task
Write a Befunge interpreter for the following simplified insutruction set:

* `[space]`  No-op
* `0-9` Push value
* `.` Pop value, output
* `^` Direction = up
* `v` Direction = down
* `<` Direction = left
* `>` Direction = right
* `?` Direction = random
* `+` Pop two values, add them, push result
* `-` Pop two values, subtract second from first, push result
* `*` Pop two values, multiply them, push result
* `/` Pop two values, divide first by second, push result (round down)
* `_` Pop value, if 0 direction = right, otherwise direction = left
* `|` Pop value, if 0 direction = down, otherwise direction = up
* `:` Duplicate top stack value
* `#` Skip next command
* `@` End program

Your program should accept Befunge code and print the appropriate output.
You may define the structure of the input but each cell must be represented by a single character.

### Examples

Prints "123":
```
1.2.3.@
```

Prints "2"s forever:
```
>2v
^.<
```
Prints "54321":
```
123v
v54<
.>v@
....
>^>^
```
Prints 1 through 20:
```
>1+:.:v
| -*54<
@
```
