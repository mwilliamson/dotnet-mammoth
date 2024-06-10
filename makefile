.PHONY: build

build:
	couscous
	dotnet build

.PHONY: test

test: build
	mono --debug packages/xunit.runner.console.2.1.0/tools/xunit.console.exe Mammoth.Tests/bin/Debug/net45/Mammoth.Tests.dll -noshadow
