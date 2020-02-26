export const befunge = (input: string[]) => {
    const currentInstruction = input[0]
    input.forEach( item => {
        interpret(item) 
    })

    return output

}

export let output: string[] = []
export let storage: string[] = []

export const interpret = (currentInstruction: string) => {  
    if (currentInstruction === '@') {
        return output
    }
    if (["0","1","2","3","4","5","6","7","8","9"].includes(currentInstruction)) {
        storage.push(currentInstruction)
    }
    if (currentInstruction === '.') {
        output.push(storage.pop())
    }
    return output
}
