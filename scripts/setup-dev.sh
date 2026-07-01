#!/usr/bin/env bash
set -euo pipefail

REPO_ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$REPO_ROOT"

echo "==> Moonpig Training Code Katas - Development Environment Setup"
echo

install_dotnet() {
  if command -v dotnet >/dev/null 2>&1; then
    echo "  .NET SDK already installed: $(dotnet --version)"
    return
  fi

  echo "  Installing .NET SDK 8.0..."
  curl -fsSL https://dot.net/v1/dotnet-install.sh | bash -s -- --channel 8.0 --install-dir "$HOME/.dotnet"
  export PATH="$HOME/.dotnet:$PATH"
  echo 'export PATH="$HOME/.dotnet:$PATH"' >> "$HOME/.bashrc"
}

install_stack() {
  if command -v stack >/dev/null 2>&1; then
    echo "  Haskell Stack already installed: $(stack --version | head -1)"
    return
  fi

  echo "  Installing Haskell Stack..."
  curl -fsSL https://get.haskellstack.org/ | sh -s - -f
  export PATH="$HOME/.local/bin:$PATH"
  echo 'export PATH="$HOME/.local/bin:$PATH"' >> "$HOME/.bashrc"
}

ensure_system_packages() {
  if command -v apt-get >/dev/null 2>&1; then
    echo "  Ensuring system packages (Java, Chromium for Karma)..."
    sudo DEBIAN_FRONTEND=noninteractive apt-get update -qq
    sudo DEBIAN_FRONTEND=noninteractive apt-get install -y -qq \
      openjdk-21-jdk \
      chromium-browser \
      >/dev/null 2>&1 || true
  fi
}

echo "==> Checking prerequisites"
ensure_system_packages
install_dotnet
install_stack
export PATH="$HOME/.dotnet:$HOME/.local/bin:$PATH"

echo
echo "==> Installing template dependencies"

echo "  TypeScript..."
(cd "Quickstart Templates/Typescript" && npm install --silent)

echo "  JavaScript..."
(cd "Quickstart Templates/JavaScript" && npm install --legacy-peer-deps --silent)

echo "  Kotlin (Gradle wrapper download)..."
(cd "Quickstart Templates/kotlin" && chmod +x gradlew && ./gradlew --version --no-daemon -q)

echo "  Haskell (Stack dependencies)..."
(cd "Quickstart Templates/haskell" && stack setup --silent)

echo "  .NET (restore packages)..."
dotnet restore "Quickstart Templates/NetCore/CodeKatas.csproj" --verbosity quiet
dotnet restore "Katas/GildedRose/dotnetcore/GildedRose.sln" --verbosity quiet

echo
echo "==> Setup complete"
echo
echo "Run './scripts/verify-dev.sh' to confirm the environment is working."
