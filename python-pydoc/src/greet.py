#!/usr/bin/python3

class CGreeter(object):
	""" This class provides greeting functions. """

	def SayHello(self, name):
		""" This method provides a hello greeting.
		
		Arguments:
		name -- Name of the person to greet.
		"""
		print("Hello {0}!".format(name))

	def SayGoodbye(self, name):
		""" This method provides a goodbye greeting.
		
		Arguments:
		name -- Name of the person to greet.
		"""
		print("Goodbye {0}!".format(name))

myGreeter = CGreeter()
myGreeter.SayHello("Jim")
myGreeter.SayGoodbye("Jim")
