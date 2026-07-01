#!/usr/bin/env bash
set -euo pipefail

REPO_ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$REPO_ROOT"

export PATH="$HOME/.dotnet:$HOME/.local/bin:$PATH"
export CHROME_BIN="${CHROME_BIN:-/usr/bin/google-chrome-stable}"

PASS=0
FAIL=0
SKIP=0

run_check() {
  local name="$1"
  shift

  printf "  %-28s " "$name"
  if output="$("$@" 2>&1)"; then
    echo "PASS"
    PASS=$((PASS + 1))
    return 0
  else
    echo "FAIL"
    echo "$output" | sed 's/^/    /'
    FAIL=$((FAIL + 1))
    return 1
  fi
}

skip_check() {
  local name="$1"
  local reason="$2"
  printf "  %-28s " "$name"
  echo "SKIP ($reason)"
  SKIP=$((SKIP + 1))
}

echo "==> Verifying development environment"
echo

run_check "Go" bash -c 'cd "Quickstart Templates/go" && go test ./...'
run_check "TypeScript" bash -c 'cd "Quickstart Templates/Typescript" && npm test --silent'
run_check "Kotlin" bash -c 'cd "Quickstart Templates/kotlin" && ./gradlew test --no-daemon -q'
run_check "Haskell" bash -c 'cd "Quickstart Templates/haskell" && stack test --silent'
run_check "JavaScript" bash -c 'cd "Quickstart Templates/JavaScript" && npm test --silent'

# NetCore template includes an intentionally failing starter test.
if output="$(cd "Quickstart Templates/NetCore" && dotnet test --verbosity quiet 2>&1)"; then
  printf "  %-28s " ".NET (NetCore)"
  echo "PASS"
  PASS=$((PASS + 1))
else
  if echo "$output" | grep -q "SampleFailed"; then
    printf "  %-28s " ".NET (NetCore)"
    echo "PASS (starter test fails by design)"
    PASS=$((PASS + 1))
  else
    printf "  %-28s " ".NET (NetCore)"
    echo "FAIL"
    echo "$output" | sed 's/^/    /'
    FAIL=$((FAIL + 1))
  fi
fi

# Gilded Rose is a kata — tests fail until you implement the solution.
if output="$(cd "Katas/GildedRose/dotnetcore" && dotnet test --verbosity quiet 2>&1)"; then
  printf "  %-28s " "GildedRose (.NET)"
  echo "PASS"
  PASS=$((PASS + 1))
else
  if echo "$output" | grep -qE "Failed!|Test Run"; then
    printf "  %-28s " "GildedRose (.NET)"
    echo "PASS (kata tests fail by design)"
    PASS=$((PASS + 1))
  else
    printf "  %-28s " "GildedRose (.NET)"
    echo "FAIL"
    echo "$output" | sed 's/^/    /'
    FAIL=$((FAIL + 1))
  fi
fi

echo
echo "Results: $PASS passed, $FAIL failed, $SKIP skipped"

if [ "$FAIL" -gt 0 ]; then
  exit 1
fi
