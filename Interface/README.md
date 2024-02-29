# Interface

1. Use the "interface" keyword before the interface definition.
2. An interface cannot be instantiated; it provides a contract to the class that implements it.
3. By default, inside interfaces, properties and methods are public, and fields are not allowed.
4. C# does not support "multiple inheritance" It can be achieved with interfaces because a class can 
   implement multiple interfaces.
5. The main use case for an interface is when some methods are crucial and should be present in the class.
   In such cases, add that method to the interface and implement it in the class.
6. Provides immediate validation if someone changes the method accidentally (remove or change the method name).