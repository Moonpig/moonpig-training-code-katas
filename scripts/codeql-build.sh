#!/bin/bash -e

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
WORKSPACE="${GITHUB_WORKSPACE:-$ROOT_DIR}"

cd "$WORKSPACE"

if [[ -f ".config/dotnet-tools.json" ]]; then
  dotnet tool restore
fi

SLN=$(find . -name "*.sln" -not -path "*/node_modules/*" -not -path "*/bin/*" -not -path "*/obj/*" | head -1)

if [[ -n "$SLN" ]]; then
  echo "Building $SLN"
  dotnet build "$SLN" -c Release
else
  echo "No .sln found — trying dotnet build at repo root"
  dotnet build -c Release
fi
