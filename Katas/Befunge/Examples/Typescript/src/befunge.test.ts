import { befunge, interpret, output, storage } from './example'

describe('Befunge', () => {
  beforeEach(() => {
    storage = []
    output = []
  })
  it('will end program', () => {
    const output = befunge(['@'])
    expect(output).toEqual([])
  })

  it('will interpret two rows', () => {
    const output = befunge(['1', '.', '@'] )
    expect(output).toEqual(['1'])
    })
  })

  it('will do example 1', () => {
    const output1 = befunge(['1','.','2','.','3','.','@'])
    expect(output1).toEqual(['1','2','3'])
  })


  describe('interpret', () => {
    beforeEach(() => {
      storage = []
      output = []
    })
    it('interprets a number', () => {
      interpret('1')
      expect(storage).toEqual(['1'])
    })

    it('interprets another number', () => {
      interpret('2')
      expect(storage).toEqual(['2'])
    })
    it('interprets two numbers', () => {
      interpret('1')
      interpret('2')
      expect(storage).toEqual(['1','2'])
    })
    it('interprets a big number', () => {
      interpret('10')
      expect(storage).toEqual([])
    })
    it('will pop to output', () => {
      storage = ['1']
   
      interpret('.')
      expect(output).toEqual(['1'])
    })
  })
