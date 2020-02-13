import { add } from './example'

describe('Using Add', () => {
  it('adds numbers',() => {
	expect(add(2,2)).toBe(4)
  })
})
