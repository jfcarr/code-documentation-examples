#include <iostream>

using namespace std;

/** \brief Greeter class.

 This class provides functionality for issuing greetings.
 */
class CGreeter
{
public:
	/** \brief Say hello.
	 @param[in]  name  Name of the person you're saying hello to.
	 
	 \return Always returns a zero for success.
	 
	 Use this function to say hello.	 
	 */
	int SayHello(char *name);

	/** \brief Say goodbye.
	 @param[in]  name  Name of the person you're saying goodbye to.
	 
	 \return Always returns a zero for success.
	 
	 Use this function to say goodbye.	 
	 */
	int SayGoodbye(char *name);
};
