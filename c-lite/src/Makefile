default:
	@echo 'Targets:'
	@echo '  greet'
	@echo '  clean'

greet: main.o
	gcc -o greet main.o

main.o: main.c
	gcc -c main.c

clean:
	-rm -f main.o
	-rm -f greet
