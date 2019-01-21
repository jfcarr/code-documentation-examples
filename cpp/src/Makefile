FMT=astyle

default:
	@echo "Targets:"
	@echo " build"
	@echo " format"
	@echo " clean"

build: greet

greet: main.o lib.o
	g++ -o greet main.o lib.o

main.o: main.cpp
	g++ -c main.cpp

lib.o: lib.cpp lib.h
	g++ -c lib.cpp

format:
	@$(FMT) main.cpp
	@$(FMT) lib.cpp
	@$(FMT) lib.h

clean:
	-rm -f greet
	-rm -f main.o
	-rm -f lib.o
	-rm -f *.orig
