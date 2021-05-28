Design Pattern
	Separation 
	Abstraction


	Seperation----Encapsulation-------Inheritance---RuntimePloymorphism---->Abstraction 
		       ------SRP-------------------------------------------------------DIP--->



	Seperation ------->Object Oriented Analysis Design
				Object Design / Class Design / Function	
					Encapsulation
						Identify Role and Assign Responsibilities
						High Cohesion
							Eliminate Non-Communication Behavior
							Function - High Cyclomatic Complexity
					Principle : Single Responsibility Principle
	
					"Distribute Functionalities" - Seperation
	
					Smell : God Class, Brain Class , Brain method
	
		UI Layer -> Ui - Unit testing 
				 TDD
				View-> GOD Class, VIEW
					UI,LOGIC,DATA	
				MVC, MVVP,MVVM
			Multiple Components

**Finacial Risk Calculator System**

1.Importing TradeData and Reference Data from xml
2.Configure or define external Parameters
3.Calculating Risk
4.Generating RiskReport
5.Merging Imported Data
6.Excel Exporter

1. **Encapsulation (Seperation - SRP)**

**Define roles and Assign Responsibilities**

RiskCalculator
RiskReportGenerator
TradeDataModel
ReferenceDataModel
ExcelExporter
TradeDataXMlImporter
ReferenceDataXMLImporter
ConfigurationParamerterModel
RiskInputDataMerger
RiskReportModel
RiskInputDataModel
RiskCalculationDataProcessor

2. **Reusability - Demands - Relationship**
   	a. One Role **Assumes** Another Role - is-a relationship  [Inheritance]

   1. ​	Compile time Relationship (Birth)
   2. ​     OneWay 
   3. ​     Child must have interface of Parent (Ripple Effect)
   4. ​     Powerfull (**Complete Code Reuse**) concept .. always abused
   5. ​     Diamond Problem
   6. ​     Class Proliferation

   

   ​	b. One Role **Uses** Another Role - has-a Relationship [Association,Composition,Aggregation] - Object Reuse

   	1. Two way reuse
    	2. Dynamic Relationship (Marriage - Divorce)
    	3. Lazy Instantiation
    	4. No Ripple Effect 	
    	5. Cardinality Can be changed 

	Note: "Favor has-a over is-a"
	      "Prefer Composition Over Inheritance"
> RiskCalculationDataProcessor uses RiskCalculator
>
> RiskCalculationDataProcessor uses TradeDataXMLImporter
>
> RiskCalculationDataProcessor uses ReferenceDataXMlImporter
>
> Uses -->   **Dependency**



3. **Dependency Management** (Has-a Relationship - Marriage)

   1. unit test 
   2. Change

   **Dependency Inversion Principle**  - **Abstraction** (Hide) - transparent -contract

   > Program For Interface not for Implementation

   **Benefits Of Abstraction**

   - Change (Loosly Coupled)
   - Unit testing (Substitute actual dependency using fake / stud/mock objects)

   

   **Abstraction  is a Result of Runtime Polymorphism**

   **classDiagram**

     IFilter <|-- MRNSearchFilter

   

   ### Strategy Pattern

   >
   >
   >- Runtime Polymorphism
   >- SRP and DIP
   >- Enable to client to select/Substitute objects /Services @Runtime
   >- Defer selection of algorithm 
   >- Family of Algorithms , strategy allows the program to substitute one member of the family with another @runtime 
   >- Client depends on abstraction (base class pointer or function pointer)of family members 
   >- Strategy can be implemented using
   > -  Runtime Polymorphism 
   > - Function Pointers ( C# use delegates)
   >- Related Pattern :- Composite Pattern
   >- Implementing strategies using Runtime Polymorphism  gives you a lot more options when it comes to keeping track of state, organizing things into multiple methods, sharing code between implementations, etc.. Force Developer to adopt SRP

   Note : - Runtime Polymorphism v/s Function Pointers 

   

   ## Composite Pattern

   > - Allows to substitute one object (leaf) with Many Objects (composite)
   >
   > - Multicasting  (one to many)
   >
   >   - window is composite
   >   - Directory - File
   >   - C# Delegate - Multicast Delegate Instance
   >
   > - Composite Object Delegates work to contained objects
   >
   > - Allows Client to treat individual or Group of objects uniform manner
   >
   > - Composite uses Iterator Pattern
   >
   > - Use Composite pattern - When Objects are in hierarchy 
   >
   >   - UI
   >   - XML
   >   - MVC  - View implemented using Composite Pattern
   >   - Composite Strategy
   >   - Composite Command
   >
   >   
   >
   > 
   
   ### Visitor Pattern
   
   > - OCP 
>
   > - Double Dispatch Problem
>
   > - How to add new Virtual Operation for each member of **Object Structure** without modifying structure 
>
   > -  when new object structure member  introduced, visitor classes need to be updated 
   >
   > - Visitor Pattern Key Logic - "this" polymorphic static binding  
   >
   > - Every Element of Object Structure must have method for  accepting visitor object and callback respective visitor method by passing "this" value.
   >
   > - Usage : Tree Parsers , Document Processors
   >
   >   

   

   ### State Pattern

> Uses Strategy pattern
>
> Eases transition b/w states , Add new state , Remove state 
>
> Distribute Object state mgmt.. complicity - across individual classes(SRP).
>
> Context and States
>
> Context Delegates request -> current State 
>
> Context Depends On abstraction of State
>
> State Depends on abstraction / Concrete Context
>
> Each State Determine next possible state 
>
> ex:  Circuit Breaker Pattern , Thread State Mgmt.. , Finite Automata 
>
> 

   ### Decorator Pattern

> Add Behavior to an object @runtime without affecting other instances of same type
>
> Decorator holds is-a and has- a relationship with the abstraction of the object to be decorated
>
> Object being decorated will be called @last
>
> Once the object is decorated - all the decorator logic  will be executed 
>
> ex:- I/o stream (buffering) , UI Control Decoration (Scroll bars, An- Notation), wpf adorners) 
>
> Supporting Pattern : Fluent Interface Pattern



### Proxy Pattern

> Wrapper Flavour
>
> For the client, usage of a proxy object is similar to using the real object, because both implement the same interface.
>
> Proxy Can Intercept, Queue , Modify Request for real object , Deny forwarding request - real object
>
> Proxy enable Controlled Access to a real object
>
> Ex: DB Proxy , Caching , Service Proxy , Network Proxy (internet proxy)



### Observer Pattern

> Notification Pattern
>
> Actors : Subject - who has state , observer - who like to listen for subject state change
>
> Responsibilities 
>
> - Subject
>   - Domain related state and Behavior
>   - List of Observers
>   - Hook Methods
>     - Subscribe
>     - UnSubscribe
>   - Iterate and Notify Observers
> - Observer
>   - Domain related and state Behavior
>   - Register and Unregister for state change
>
> Relationships
>
> - Subject Depends on Abstraction Of Observer
> - Observer Depends on Abstraction Of Observer
> - Subject should not send state information , while noticing observer  ,Instead let subject have api in its abstraction like **getState**() and this method invoked once observer gets notification from subject
> - Observer written using Strategy or Composite Strategy  and Command / Object Adapter pattern 
>
> Usage 
>
> - event driven Programming
> - Intermediate -Callback implementation
> - State Notification



### Mediator Pattern

---

- Encapsulate how a set of objects interact
- Event - Bus 
- Decouples Subject from Observers
- EventAggregator 

#### Builder Pattern

---

- Step By Step Construction
- Complex Object - structure 
- Different Representation
- Actors :- Product , Builders, Director , Client
- Client--->Director ---->Instructs ----> Builder --> Builds and Assemble Product Parts
- Supporting Pattern - > Fluent Interface Pattern
- Ex: - StringBuilder , ConnectionStringBuilder , DOM Builder, Document Builder



### Prototype Pattern

---

- Creational Pattern 

- Inherent cost of creating a new object in the standard way (e.g., using the '[new](https://en.wikipedia.org/wiki/New_(C%2B%2B))' keyword) when it is prohibitively expensive for a given application.

- Cloning

- 

- 

- 

  - Deep
  - Shallow

  

  

  ### Memento Pattern

  ---

  - object state reset

  - Snapshot

  - Undo 

  - Actors - CareTaker , Memento , Orignator

  - CareTaker-> Originator (has state) ->CreateMemento 

  - Memento - Object hold state of Originator

  - Usecases : undo /redo

    

    

    

    ### FlyWieght

    ---

    - Object -> Shared state and NonShared State
    - Object receives nonshared state on the fly when certain operations   being called 
    - Flyweights object created and preserved by Factory
    - Allows to reduce memory foot print of object
    - useCases : TextEditior , Drawing Tool 

  ### Singleton

  ---

  - Private Constructor or MonoState Pattern

    - Null Check  

    - Thread Safe 

      - Double  - Null  Check

    - Eager / Lazy Instantiation 

    - Reflection (.Net / Java )

    - Serialization and Deserialization 

    - Performance vs Laziness 

    - Java :- enum based singleton objects  (Protects from reflection

  

  
  ### Bridge Pattern

  ------

  

  - Favor Composition over Inheritance
  
- Separate Abstraction from Implementation
    - Let Abstraction Hold has-a relationship with implementation
  - Both Can vary Indepenendentaly
  - Inheritance Based solution results in **class proliferation**
  
- Usage VM Development , Platform Programmers , Driver Development
  - Bridge Pattern results with - Orthogonal Inheritance Hierarchy (Parallel Inheritance)

  

  ### Adapter

  ---

  - Interface Mismatch
  
- Adpatee , Adpater,Client
  - Types Of Adapaters
  - Class Adapter
      - is-a 
    - Adapter will get interface of Adaptee
      - Complete Code Reuse (aka Versioningd)
  - Object Adapter
      - has-a 
    - Adpater will no have interface Adaptee
  - Converts one interface to another so that it matches what the client is expecting

  

  ### Abstract Factory Pattern

  ---

  - Strategy for Factories

  - Client can choose Factory @runtime

  - Factory responsible for instantiating related objects

  - Client Depends on Abstraction of Factories and Objects 

    

  

  ### Command Pattern

  ---

  - Object Communication Seperated / Seperator Pattern

  - Ecasulate Object Request

  - Source--->Seperator--->Target

  - Seperator Hold all the information to perform action  on target

  - Usage : History , Repetitive  , Request Validation 

  - Example : Command pattern in MVVM , CQRS Design pattern
  
  - Structure wise same as Object Adapter Pattern
  
  - What is the Difference b/w Object Adapter pattern v/s Command Pattern
  
    - Adapter has intelligence 
  
    - Command - is-a Delegator  ( delegate invoke())
  
      
    
      
    
    
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  















