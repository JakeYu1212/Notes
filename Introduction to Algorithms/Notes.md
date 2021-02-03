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

Algorithm analysis is concerned with comparing algorithms based upon the amount of computing resources that each algorithm uses. 

This measure would then be useful for judging the algorithm alone and could be used to compare algorithms across implementations.

![../_images/newplot.png](https://runestone.academy/runestone/books/published/pythonds/_images/newplot.png)

On many occasions you will need to make decisions between time and space trade-offs.

#### 3.6 Lists

Two common operations are indexing and assigning to an index position. Both of these operations take the same amount of time no matter how large the list becomes. When an operation like this is independent of the size of the list they are 𝑂(1)O(1).

Another very common programming task is to grow a list. There are two ways to create a longer list. You can use the append method or the concatenation operator. ==The append method is 𝑂(1). However, the concatenation operator is 𝑂(𝑘)== where 𝑘 is the size of the list that is being concatenated.

To use `timeit` you create a `Timer` object whose parameters are two Python statements. The first parameter is a Python statement that you want to time; the second parameter is a statement that will run once to set up the test. The `timeit` module will then time how long it takes to execute the statement some number of times. By default `timeit` will try to run the statement one million times. When its done it returns the time as a floating point value representing the total number of seconds. However, since it executes the statement a million times you can read the result as the number of microseconds to execute the test one time. You can also pass `timeit` a named parameter called `number` that allows you to specify how many times the test statement is executed. 

**Table 2: Big-O Efficiency of Python List Operators**

| Operation        | Big-O Efficiency |
| :--------------- | :--------------- |
| index []         | O(1)             |
| index assignment | O(1)             |
| append           | O(1)             |
| pop()            | O(1)             |
| pop(i)           | O(n)             |
| insert(i,item)   | O(n)             |
| del operator     | O(n)             |
| iteration        | O(n)             |
| contains (in)    | O(n)             |
| get slice [x:y]  | O(k)             |
| del slice        | O(n)             |
| set slice        | O(n+k)           |
| reverse          | O(n)             |
| concatenate      | O(k)             |
| sort             | O(n log n)       |
| multiply         | O(nk)            |

#### 3.7 Dictionaries

**Table 3: Big-O Efficiency of Python Dictionary Operations**

| operation     | Big-O Efficiency |
| :------------ | :--------------- |
| copy          | O(n)             |
| get item      | O(1)             |
| set item      | O(1)             |
| delete item   | O(1)             |
| contains (in) | O(1)             |
| iteration     | O(n)             |

# 4. Basic Data Structures

