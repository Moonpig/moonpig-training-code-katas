# Counting Code Lines

Source: http://codekata.com/kata/kata13-counting-code-lines/

Counting lines of code in Java source is not quite as simple as it seems.

This week let’s write something vaguely useful: a utility that counts the number of lines of actual code in a Java source file. For the purpose of this exercise, a line is counted if it contains something other than whitespace or text in a comment. Some simple examples:

```Java
// This file contains 3 lines of code
public interface Dave {
    /**
    * count number of lines in a file
    */
    int countLines(File inFile);// not the real signature!
}
```
and...
```Java
    /*****
     * This is a test program with 5 lines of code
     *  \/* no nesting allowed!
     //*****//***/// Slightly pathological comment ending...

    public class Hello {
        public static final void main(String [] args) { // gotta love Java
          // Say hello
          System./*wait*/out./*for*/println/*it*/("Hello/*");
        }

    }
```

Java comments are either `//` to the end of line, or `/*` to the next `*/`. The block comments do not nest. There may be multiple /* … */ comments on a line. Whitespace includes tabs, spaces, carriage returns, and vertical tabs. Oh, and remember that comment start sequences that appear inside Java strings should be ignored.

## Goals of the Kata

The mixture of line-based things (single line comments, blank lines, and so on) with the stream-based block comments can make solutions slightly ugly. While coding your solution, consider the structure of your code, and see how well it fits the structure of the problem.

Try another implementation, does what you learnt in your initial run affect your approach?
