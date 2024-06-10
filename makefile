.PHONY: build

build:
	couscous
	dotnet build

.PHONY: test

test: build
	dotnet test

.PHONY: pack

pack: test
	dotnet pack Mammoth
