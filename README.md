# moonpig-training-code-katas

A repository containing katas that we have tried at Moonpig.

## Development Environment

This repo is a collection of coding katas and language quickstart templates — not a single deployable application. Each template has its own test runner so you can practice TDD in your preferred language.

### Prerequisites

| Tool | Used by |
|------|---------|
| Go 1.22+ | `Quickstart Templates/go` |
| Node.js 18+ | `Quickstart Templates/Typescript`, `Quickstart Templates/JavaScript` |
| Java 17+ | `Quickstart Templates/kotlin` |
| .NET SDK 8.0 | `Quickstart Templates/NetCore`, `Katas/GildedRose/dotnetcore` |
| Haskell Stack | `Quickstart Templates/haskell` |
| Chromium (for Karma) | `Quickstart Templates/JavaScript` |

### Quick start

```bash
# Install dependencies and toolchains
./scripts/setup-dev.sh

# Run all template verification checks
./scripts/verify-dev.sh
```

### Running individual templates

```bash
# Go
cd "Quickstart Templates/go" && go test ./...

# TypeScript (Jest)
cd "Quickstart Templates/Typescript" && npm install && npm test

# JavaScript (Karma + Jasmine)
cd "Quickstart Templates/JavaScript" && npm install && npm test

# Kotlin (Gradle)
cd "Quickstart Templates/kotlin" && ./gradlew test

# Haskell (Stack + Hspec)
cd "Quickstart Templates/haskell" && stack test

# .NET (xUnit)
cd "Quickstart Templates/NetCore" && dotnet test

# Gilded Rose kata (.NET)
cd "Katas/GildedRose/dotnetcore" && dotnet test
```

### Katas

Each kata lives under `Katas/` with its own README describing the exercise. The [Gilded Rose](Katas/GildedRose/README.md) kata includes a .NET Core implementation with approval tests.

### Notes

- The **NetCore** quickstart template includes a deliberately failing test (`SampleFailed`) — replace it as you work through the kata.
- **JavaScript** tests require a Chromium-based browser. Set `CHROME_BIN` if your browser binary has a different name (defaults to `/usr/bin/google-chrome-stable`).
