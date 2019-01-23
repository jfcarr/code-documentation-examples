Python also has its own accompanying documentation generator, called ```pydoc```.  (```pydoc3``` for Python 3)

If you're using pydoc instead of Doxygen, you should use Python-style docstrings, which take this form:

```
""" Documentation comment goes here """
```

Instead of the Javadoc form, which are prefixed with ##.

You can view man-style documentation on-the-fly with pydoc as follows:

```
pydoc3 ./file_name.py
```

You can also generate HTML documentation, like this:

```
pydoc3 -w file_name.py
```
