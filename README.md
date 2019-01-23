# code-documentation-examples

## Overview

These are sample documentation projects using Doxygen and other code documentation generation tools.

You can view the generated documentation in your browser by opening the index.html file in the docs folder.  There is also an example set of generated documentation files in each project's example-docs folder.

## Doxygen

In the root folder of each Doxygen sample project, you will find a Doxygen configuration file called "Doxyfile".  If you open a Terminal session and execute the `doxygen` command in the root folder, Doxyfile will be used automatically to regenerate the HTML documentation in the corresponding docs folder.  All of the source files will be scanned for documentation comments.

### Setup

Install the Doxygen CLI (**required**).  If you're using Linux, you can install it from your distribution's repo.  You can also get installation binaries from the [Doxygen home page](http://www.doxygen.nl/download.html). 

If you'd also like a friendly Doxygen configuration builder, you should install Doxygen GUI as well.

### Modify Doxygen Project Options

If you want to change the Doxygen project options, Doxyfile can be edited in a couple of ways:

1. You can edit the file directly with a text editor, or
2. You can open the file in doxywizard for a friendlier UI experience.

## Modify Project Comments

If you want to experiment with documentation comments in source files, simply edit the corresponding source files in your programmer's editor of choice, then regenerate the HTML documentation to see the results.

## Links

### Doxygen

[Doxygen Manual](http://www.doxygen.nl/manual/index.html)

[Official Doxygen git repository](https://github.com/doxygen/doxygen)

### XML Comments in C#

[Documenting your code with XML comments | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc)

[XML Documentation Comments - C# Programming Guide | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)
