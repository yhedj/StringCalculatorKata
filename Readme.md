Solid Exercices
===============

The goal is to implement a digital calculator from strings.

WARNING: do not change naming of classes, it would break the code at some point.

Here are the proposed exercices:

* First we want to implement the Calculator that can calculate simple operations: sums, products, substractions and divisions
	* A first test is given for sum, don't forget to write some for additional cases and other operations
	* Try to avoid exceptions with explicit messages if impossible to calculate
	* **Q1**: what can you do to avoid lots of ifs or a switch?
* If it is not the case, remove any conditions about the operation to apply
	* **Q2**: what is the core concept of object-oriented programmation you are using?
* If it is not the case, make your calculator not aware of concrete operations it supports
	* **Q3**: what is the principles you are applying in this case?
* Then, we have a CalculatorTrainer class (and a console application using it) that run several operations stored in an array against Calculator
	* NB: you need to include the CalculatorTrainer class in the SolidExercices project and add the project SolidExercices.Console
	* **Q4**: what are the issues with this class?
* Make your Calculator implementation able to give a result for these operations (for impossible cases, return a standard ArgumentException with an explicit message => caught by CalculatorTrainer)
	* Don't forget tests!
* Extract operations in a class
	* **Q5**: what is the principle you are applying in this case?
* Make the trainer independent from this class with an abstraction + extract instanciation of any classes out of the trainer class
	* **Q6**: what is the principle you are applying in this case?
* Now we would like to access a list of operations from a link (URL) => implement the previous abstraction to access this URL
	* Format returned by the URL will be JSON, i.e `[ {operation: ""}, { ...}, ...]`
	* Adapt the console application to take URL as first parameter, and when URL given, use it to retrieve operations
* For now, trainer is just a command line, create a Web API to expose the following contract:
	* POST /calculate
		{ operation: "...an operation..." }
	* POST /train 
		{ from: "...some URL..."}
