# DEPENDENCY INJECTION IN ASP.NET MVC
 -  Dependency Injection is an implementation of "Inversion of Control". Inversion of Control (IoC) says that the objects do <br>
  not create other objects on which  they rely to do their work; instead, they get the objects that they need from an outside source.

- Technically, Dependency Injection or DI is defined as a software design pattern which implements Inversion of control (IOC) for 
resolving dependencies across objects. <br>
The dependency is an object (or a service object), which is passed as dependency to the consumer object (or a client application). <br>
This is a pattern using which decoupling (or loose-coupling) across components can be implemented easily.

- When ObjectA wants to access methods (or operations) of ObjectB, then instead of directly instantiating ObjectB in ObjectA,
 ObjectB is injected into ObjectA as a dependency. <br>
In this case, ObjectB implements an interface, which is passed to ObjectA. Hence ObjectB is not instantiated using new in ObjectA. <br>
The advantage of this approach is that if in future ObjectB has any modifications, ObjectA need not be refreshed.

**problem**
- Tightly Coupled
- controller know where the code is written they can access all method of classes

**way to resolve dependency**
- Constructor
- Method
- property


**Advantage**
- Loosely Coupled
- Reduce Dependency
- No Revealing of code
- more readable code
