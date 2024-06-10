.PHONY: build

build:
	couscous
	dotnet build

.PHONY: test

test: build
	dotnet test
