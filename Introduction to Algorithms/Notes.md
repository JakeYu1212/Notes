# **1.Introduction**

In addition, programmers can create their own exceptions if they detect a situation in the program execution that warrants it.

When an exception occurs, we say that it has been “raised.” You can “handle” the exception that has been raised by using a try statement.try:

```
try:    

   print(math.sqrt(anumber))

except:    

   print("Bad Value for square root")

   print("Using absolute value instead")

   print(math.sqrt(abs(anumber)))
```

we use abstract data types to provide the logical description of what a data object looks like (its state) and what it can do (its methods).

The first method that all classes should provide is the constructor. The constructor defines the way in which data objects are created. In Python, the constructor method is always called __init__.

greatest common divisor, or GCD

Euclid’s Algorithm states that the greatest common divisor of two integers 𝑚 and 𝑛 is 𝑛 if 𝑛 divides 𝑚 evenly. However, if 𝑛 does not divide 𝑚 evenly, then the answer is the greatest common divisor of 𝑛 and the remainder of 𝑚 divided by 𝑛.

Any new logic gate that gets added to the hierarchy will simply need to implement the performGateLogic function and it will be used at the appropriate time. Once done, the gate can provide its output value. This ability to extend a hierarchy that currently exists and provide the specific functions that the hierarchy needs to use the new class is extremely important for reusing existing code.

This is a very common pattern that you should always use when building class hierarchies. Child class constructors need to call parent class constructors and then move on to their own distinguishing data.

When designing classes, it is very important to distinguish between those that have the IS-A relationship (which requires inheritance) and those that have HAS-A relationships (with no inheritance).

# 2. A Proper Class

- Each class should have a docstring to provide some level of documentation on how to use the class.
- Each class should have a `__str__` magic method to give it a meaninigful string representation.
- Each class should have a proper `__repr__` magic method for representation in the interactive shell, the debugger, and other cases where string conversion does not happen.
- Each class should be comparable so it can be sorted and meaningfully compared with other instances. At a minimum this means implementing `__eq__` and `__lt__`.
- You should think about access control each instance variable. Which attributes do you want to make public, which attributes do you want to make read only, and which attributes do you want to control or do value checking on before you allow them to be changed.

# 3. Analysis

 In Python, we can benchmark a function by noting the starting time and ending time with respect to the system we are using.

In the `time` module there is a function called `time` that will return the current system clock time in seconds since some arbitrary starting point.

```
time.time()
```

