#include <stdio.h>

/** \brief Say hello.

 @param[in]  name  Name of the person you're saying hello to.

 \return Always returns a zero for success.

 Use this function to say hello.
 */
int say_hello(char *name) {
	printf("Hello %s!\n", name);

	return 0;
}

/** \brief Say goodbye.

 @param[in]  name  Name of the person you're saying goodbye to.

 \return Always returns a zero for success.

 Use this function to say goodbye.
 */
int say_goodbye(char *name) {
	printf("Goodbye %s!\n", name);

	return 0;
}

/**
 This is the program entry point.
 */
void main() {
	say_hello("Jim");
	say_goodbye("Jim");
}
