package example

import "testing"

func TestAddition(t *testing.T) {
  expected := 4
  if observed := Add(2,2); observed != expected {
	t.Fatalf("Add(2,2) = %v, want %w", observed, expected)
  }
}
