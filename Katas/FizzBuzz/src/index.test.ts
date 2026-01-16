jest.mock("./fizzBuzz");
jest.mock("readline");

describe("FizzBuzz CLI", () => {
  let consoleLogMock: jest.SpyInstance;
  let fizzBuzzMock: jest.Mock;
  let mockRlInterface: any;
  let lineHandler: (input: string) => void;

  beforeEach(() => {
    jest.resetModules();

    consoleLogMock = jest.spyOn(console, "log").mockImplementation();

    // Re-import the mocked function after resetModules
    fizzBuzzMock = require("./fizzBuzz").fizzBuzz as jest.Mock;

    // Setup readline mock
    const readline = require("readline");
    mockRlInterface = {
      on: jest.fn((event, handler) => {
        if (event === "line") {
          lineHandler = handler;
        }
      }),
    };
    readline.createInterface.mockReturnValue(mockRlInterface);
  });

  afterEach(() => {
    consoleLogMock.mockRestore();
  });

  it("should call fizzBuzz function for first value", () => {
    require("./index");

    expect(fizzBuzzMock).toHaveBeenCalledTimes(1);
    expect(fizzBuzzMock).toHaveBeenCalledWith(1);
  });

  it("should log the result of fizzBuzz to console", () => {
    const mockFizzBuzzResult = "Mocked FizzBuzz Result";
    fizzBuzzMock.mockReturnValue(mockFizzBuzzResult);

    require("./index");

    expect(consoleLogMock).toHaveBeenCalledWith(mockFizzBuzzResult);
  });

  describe("after user hits enter", () => {
    it("should call fizzBuzz for the next number", () => {
      fizzBuzzMock.mockReturnValue("mocked");

      require("./index");

      lineHandler("");

      expect(fizzBuzzMock).toHaveBeenCalledWith(2);
    });

    it("should log the next fizzBuzz result to console", () => {
      const firstMockResult = "First Mocked Result";
      const secondMockResult = "Second Mocked Result";
      fizzBuzzMock
        .mockReturnValueOnce(firstMockResult)
        .mockReturnValueOnce(secondMockResult);

      require("./index");

      lineHandler("");

      expect(consoleLogMock).toHaveBeenCalledWith(secondMockResult);
    });
  });
});
