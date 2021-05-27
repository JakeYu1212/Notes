# **1. Introduction**

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

Any new logic gate that gets added to the hierarchy will simply need to implement the perform GateLogic function and it will be used at the appropriate time. Once done, the gate can provide its output value. This ability to extend a hierarchy that currently exists and provide the specific functions that the hierarchy needs to use the new class is extremely important for reusing existing code.

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

#### 4.7 Infix, Prefix and Postfix Expressions

Only infix notation requires the additional symbols. The order of operations within prefix and postfix expressions is completely determined by the position of the operator and nothing else

#### 4.14 Simulation: Printing Tasks

However, it is important to remember that the simulation is only as good as the assumptions that are used to build it. Real data about the number of print tasks per hour and the number of students per hour was necessary to construct a robust simulation.

#### 4.15 What Is a Deque?

In a sense, this hybrid linear structure provides all the capabilities of stacks and queues in a single data structure.

#### 4.19 Lists

A **list** is a collection of items where each item holds a relative position with respect to the others.

#### 4.21 Implementing an Unordered List: Linked Lists

Each **node** object must hold at least two pieces of information. First, the node must contain the list item itself. We will call this the **data field** of the node. In addition, each node must hold a **reference** to the next node.

#### 4.22 The Ordered List Abstract Data Type

The structure of an ordered list is a collection of items where each item holds a relative position that is based upon some underlying characteristic of the item. 

#### 4.23 Implementing an Ordered List

node and link structure is ideal for representing the relative positioning of the items.

# 5. Recursion

The goals for this chapter are as follows:

- To understand that complex problems that may otherwise be difficult to solve may have a simple recursive solution.
- To learn how to formulate programs recursively.
- To understand and apply the three laws of recursion.
- To understand recursion as a form of iteration.
- To implement the recursive formulation of a problem.
- To understand how recursion is implemented by a computer system.

Usually recursion involves a function calling itself. While it may not seem like much on the surface, recursion allows us to write elegant solutions to problems that may otherwise be very difficult to program.

A recursive function is a function that calls itself.

**The Three Laws of Recursion**

1. A recursive algorithm must have a **base case**.
2. A recursive algorithm must change its state and move toward the base case.
3. A recursive algorithm must call itself, recursively.

When a function is called in Python, a **stack frame** is allocated to handle the local variables of the function. When the function returns, the return value is left on top of the stack for the calling function to access.

The stack frames also provide a scope for the variables used by the function. Even though we are calling the same function over and over, each call creates a new scope for the variables that are local to the function.

# 6. Sorting and Searching

#### 6.5 Hashing

The mapping between an item and the slot where that item belongs in the hash table is called the **hash function**. The hash function will take any item in the collection and return an integer in the range of slot names, between 0 and *m*-1.

Now when we want to search for an item, we simply use the hash function to compute the slot name for the item and then check the hash table to see if it is present. This searching operation is O(1)O(1), since a constant amount of time is required to compute the hash value and then index the hash table at that location. If everything is where it should be, we have found a constant time search algorithm.

Given a collection of items, a hash function that maps each item into a unique slot is referred to as a **perfect hash function**.

Our goal is to create a hash function that minimizes the number of collisions, is easy to compute, and evenly distributes the items in the hash table.

The important thing to remember is that the hash function has to be efficient so that it does not become the dominant part of the storage and search process.

It is important to note that the size of the “skip” must be such that all the slots in the table will eventually be visited. Otherwise, part of the table will be unused. To ensure this, it is often suggested that the table size be a prime number.

#### 6.6 Sorting

First, it will be necessary to compare two values to see which is smaller (or larger). The total number of comparisons will be the most common way to measure a sort procedure.

Second, when values are not in the correct position with respect to one another, it may be necessary to exchange them. This exchange is a costly operation and the total number of exchanges will also be important for evaluating the overall efficiency of the algorithm.

#### 6.7 Bubble Sort

In Python, it is possible to perform simultaneous assignment. The statement `a,b=b,a` will result in two assignment statements being done at the same time.

A bubble sort can be modified to stop early if it finds that the list has become sorted. This means that for lists that require just a few passes, a bubble sort may have an advantage in that it will recognize the sorted list and stop, which is often referred to as the **short bubble**.



