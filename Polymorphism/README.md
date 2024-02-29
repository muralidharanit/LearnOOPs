# Abstract Class

1. Use the "abstract" keyword before the class definition.
2. An abstract class cannot be instantiated; it serves as a base class for other classes.
3. If a method is declared abstract, it must be overridden in the derived classes.
4. If a method is declared 'virtual,' it may or may not be overridden in the derived class.
5. An "abstract" class should not contain a method body.
6. It is not necessary for an "abstract" class to have 'abstract' methods.
7. However, if any "abstract" method is present in the class, the class should be an "abstract" class.
8. If a method is declared "virtual" may or maynot be override in the deverived class.

In the given example:
1. In the company, salary must be paid to all employees, including interns, so it is compulsory to implement it in the derived class.
2. In a company, leaves are not applicable to internship employees, so it is not compulsory to implement them in the derived class (for interns, it is not required).
