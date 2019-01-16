# Zoo

### Introduction

- This is a zoo application. It utilizes OOP principles to instantiate different animals as objects, each inheriting different properties from their parent class.

### Techinical Outline

# Inheritance
- The ability to pass a property on to a  derived class where you can in turn share behaviors(methods) and properties to the derived class.

- Within this application, you can see inheritance throughout as there are several derived animal species inherited some or all of the various properties and behaviors from the parent.

# Abstractions
- Templating from a class to a derived or instantiated class.

- Within this applicaiton, the base classes are abstract whereas the bottom tier classes are concrete.

# Polymorphism
- The ability to change multiple classes.

- This is applied within this application through the use of abstract, virtual and concrete methods. You will see there are several properties that may be abstract in a parent class and therefore inately inherited to the child(derived) whereas some are in fact made virtual in order to allow the derived class the ability to override that property(attribute) or behavior(method).

# Encapsulation
- Encapuslation is a about access control. There are three primary access modifier: public, private and protected. 

- For Unit testing purposes, withing this application the majority of the classes involved are in fact public.

# Interface

- An interface allows another struct or clas the ability to inherit its properties or behaviors.

- Within this application, is a IHunt() and IMate() interface defined. The IHunt() Interface is implemented within the Feline, Leopard Gecko, Blue Mountain Frog and Orca structs. The IMate() Interface is implemented within the Blue Mountain Frog, Spotted Turtle and Mammal structs.

### Digital Diagram
![PHOTO](https://github.com/ntibbals/Zoo/blob/master/diagram.PNG)

# Sample OutPut
![SCREENSHOT](https://github.com/ntibbals/Zoo/blob/master/output.PNG)
![SCREENSHOT](https://github.com/ntibbals/Zoo/blob/master/output2.PNG)
