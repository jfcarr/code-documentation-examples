#!/usr/bin/python3

## This class provides greeting functions.
class CGreeter(object):

	## \brief Say hello.
	# @param  name  Name of the person you're saying hello to.
	#
	# This method provides a hello greeting.
	def SayHello(self, name):
		print("Hello {0}!".format(name))

	## \brief Say goodbye.
	# @param  name  Name of the person you're saying goodbye to.
	#
	# This method provides a goodbye greeting.
	def SayGoodbye(self, name):
		print("Goodbye {0}!".format(name))

myGreeter = CGreeter()
myGreeter.SayHello("Jim")
myGreeter.SayGoodbye("Jim")
