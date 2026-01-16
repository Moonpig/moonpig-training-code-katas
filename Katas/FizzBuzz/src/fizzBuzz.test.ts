import { fizzBuzz } from "./fizzBuzz";

describe("FizzBuzz", () => {
  it("should return return 1 for 1", () => {
    const result = fizzBuzz(1);

    expect(result).toBe("1");
  });
});
