SOLID Principles

---------------------------------------


single responsibility: the class should have one reason to change and responsible for one thing.


open close: the class should closed for modification and open for extensions.


liskov substitution: If we have a method (x) in a parent class, then every child class of that parent class when calling method (x) must do the same behavior as the parent class.


interface segregation: The class shouldn't implement interface they will not use it, or not use all methods in the interface,
smaller and specific interfaces better than a few bigger ones.


dependency inversion: High level modules should not depend upon low level modules. Both should depend on abstractions (like interfaces), instead of high level depend on low level we reversed the dependency, both are depend on abstractions.
