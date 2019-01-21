#include <iostream>
#include "lib.h"

int CGreeter::SayHello(char *name)
{
	cout << "Hello " << name << "!" << endl;

	return 0;
}

int CGreeter::SayGoodbye(char *name)
{
	cout << "Goodbye " << name << "!" << endl;

	return 0;
}

