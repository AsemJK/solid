# SOLID
## Simplify Princiles Explaination

### S - Single Responsibility Principle (SRP)

Single 
Responsibility 
Principle
A class should have 
only one reason to change. It means: 
A class should have 
only one responsibility. 
If there are more than one responsibilities, they should be separated into different classes. 
This makes the class easier to understand, maintain, and test.

### O - Open/Closed Principle (OCP)

Open-Closed 
Principle
A class should be 
open for extension 
but 
closed for modification. 
It means: 
You should be able to add new features to a class without changing its existing code. 

### L - Liskov Substitution Principle (LSP)

Liskov 
Substitution 
Principle
A subclass should be 
able to replace its parent class without any problems. 
It means: 
Any instance of a subclass should be able to be used in the same way as its parent class.
This ensures that the subclass behaves in a way that is consistent with the parent class.

### I - Interface Segregation Principle (ISP)

A class should not be forced to implement interfaces that it doesn't need.

It means:

You should break up large interfaces into smaller, more specific ones, 
ensuring that clients only depend on the methods they actually need.

### D - Dependency Inversion Principle (DIP)

High-level modules should not depend on low-level modules.

Instead, both should depend on abstractions.

It means:
you should use interfaces or abstract classes to decouple the high-level and low-level components.