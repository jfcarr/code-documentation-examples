#include <iostream>
#include "lib.h"

using namespace std;

/**
 This is the entry point of the program.
 */
main()
{
    try {
        CGreeter myGreeter;

		myGreeter.SayHello("Jim");
		myGreeter.SayGoodbye("Jim");
    }
    catch (exception &e) {
        cerr << "An error occurred: " << e.what() << endl;
    }
}
