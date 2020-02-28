# Fun With Befunge

### Background
Befunge is a two-dimensional esoteric programming language invented in 1993 by Chris Pressey with the goal of being as difficult to compile as possible. We will implement a simplified version which only deals with numbers and does not allow programs to self-modify.

A Befunge program is laid out on a two-dimensional grid of cells, each containing one ASCII character representing an instruction. Execution proceeds by means of a pointer which begins at the top-left cell and is initially travelling to the right. As it encounters instructions, they are executed. The pointer’s direction of travel can be modified by using the appropriate instructions. The only data storage available is a single stack which stores integers, this can pushed to and popped from using the relevant instructions.

### Task
Write an interpreter for the following simplified Befunge instruction set:

* `[space]`  No-op
* `0-9` Push value of cell
* `.` Pop one value, output it
* `^` Direction = up
* `v` Direction = down
* `<` Direction = left
* `>` Direction = right
* `?` Direction = random
* `+` Pop two values, add them, push result
* `-` Pop two values, subtract second from first, push result
* `*` Pop two values, multiply them, push result
* `/` Pop two values, divide first by second, push result (round down)
* `_` Pop one value, if 0 direction = right, otherwise direction = left
* `|` Pop one value, if 0 direction = down, otherwise direction = up
* `:` Duplicate top stack value
* `#` Skip next command
* `@` End program

Your program should accept a Befunge program and print the appropriate output. You may define any reasonable structure for the input as long as each cell is represented by a single character. It is an error for the pointer to land outside of the grid.

### Examples

The following examples may help you understand how Befunge works.

Prints "123":
```
1.2.3.@
```

Prints "9":
```
12+3*.@
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

Prints "123321":
```
#v123<
 >......@
```

Prints 1 through 20:
```
>1+:.:v
| -*54<
@
```

### Links
Befunger is a web-based Befunge sandbox which can be helpful for exploring the language and generating additional example programs:  
https://amicloud.github.io/fungide/

Read more about the Befunge language can be found on Wikipedia and Esolangs:  
https://en.wikipedia.org/wiki/Befunge  
https://esolangs.org/wiki/Befunge  
Note that this kata uses a simplified instruction set compared to full Befunge.
