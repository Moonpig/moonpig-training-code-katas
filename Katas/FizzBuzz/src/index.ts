import { fizzBuzz } from "./fizzBuzz";
import { createInterface } from "readline";

let currentNumber = 1;

console.log(fizzBuzz(currentNumber));
currentNumber++;

const rl = createInterface({
  input: process.stdin,
  output: process.stdout,
});

rl.on("line", () => {
  console.log(fizzBuzz(currentNumber));
  currentNumber++;
});
