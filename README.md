# Design Patterns in .NET Core

## 📄 Description

This repository demonstrates the implementation of **Design Patterns** using various versions of **.NET Core**: **3.1**, **5.0**, and **6.0**. Design patterns are essential for building scalable, maintainable, and reusable software. This project provides examples and explanations of various design patterns in the context of .NET Core applications.

The **frontend** uses a **ready-to-use template**, which ensures a responsive, modern, and user-friendly interface for displaying design pattern examples. The template can be easily customized to fit the project's needs, providing a great starting point for web development.

## 🛠️ Technologies Used

- **Backend:** .NET Core 3.1, .NET Core 5.0, .NET Core 6.0
- **Frontend:** Ready-to-use template (HTML, CSS, JavaScript, Bootstrap)
- **Design Patterns:** Includes a variety of design patterns such as Singleton, Factory, Observer, Strategy, etc.
- **Database:** Optional database support (SQL Server or any preferred database for storing examples or configuration data).
- **Authentication:** Basic authentication (optional, for secure access to pattern examples).

## 📚 Features

- **Design Pattern Examples:** Implementations of popular design patterns (e.g., Repsitory, CQRS, MediatR, Observer, etc.) in .NET Core.
- **Frontend Ready-to-Use Template:** The project uses a responsive and visually appealing frontend template for displaying design patterns and explanations.
- **Multiple .NET Core Versions:** This project demonstrates the use of **.NET Core 3.1**, **5.0**, and **6.0**, making it suitable for learning and comparison of different .NET Core versions.
- **Pattern Explanations:** Each design pattern is explained with code examples, offering insight into how they are applied in real-world applications.
- **Clean Architecture:** The project is structured in a way that separates concerns between presentation, business logic, and data access layers.
- **Easy to Customize:** The frontend template is ready to use and can be easily customized to meet project-specific needs.
- **Mobile-First Design:** The template ensures the application is mobile-friendly, making it accessible on any device.
- **Admin Panel (Optional):** Provides an admin interface to manage pattern examples and configuration (optional).

## 🗂️ Project Structure

- **Presentation Layer:** Contains the UI components that display the design patterns and pattern explanations.
- **Business Logic Layer:** Implements the logic of the design patterns and handles user interaction.
- **Data Access Layer:** Optional database layer to store examples, user preferences, or other related data.
- **Models:** Defines the structure of design patterns and their respective implementations.
- **Controllers:** Handles HTTP requests and serves the correct responses based on the user's interaction with the design patterns.
- **Views:** Displays the design pattern examples and their details in a user-friendly manner.

## 📂 Design Patterns & Files

This project includes the following design patterns, each with its own respective implementation file:

### 1. **Singleton**
   - **File:** `SingletonPattern.cs`
   - **Description:** Ensures a class has only one instance and provides a global point of access to it.

### 2. **Factory Method**
   - **File:** `FactoryMethodPattern.cs`
   - **Description:** Defines an interface for creating an object, but lets subclasses decide which class to instantiate.

### 3. **Abstract Factory**
   - **File:** `AbstractFactoryPattern.cs`
   - **Description:** Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

### 4. **Builder**
   - **File:** `BuilderPattern.cs`
   - **Description:** Allows the creation of complex objects step by step.

### 5. **Prototype**
   - **File:** `PrototypePattern.cs`
   - **Description:** Specifies the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

### 6. **Adapter**
   - **File:** `AdapterPattern.cs`
   - **Description:** Allows incompatible interfaces to work together by providing a wrapper that adapts one interface to another.

### 7. **Observer**
   - **File:** `ObserverPattern.cs`
   - **Description:** Allows an object to notify other objects about changes in its state.

### 8. **Strategy**
   - **File:** `StrategyPattern.cs`
   - **Description:** Defines a family of algorithms and makes them interchangeable.

### 9. **Command**
   - **File:** `CommandPattern.cs`
   - **Description:** Encapsulates a request as an object, thereby allowing for parameterization of clients with different requests.

### 10. **Decorator**
   - **File:** `DecoratorPattern.cs`
   - **Description:** Allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class.

### 11. **Facade**
   - **File:** `FacadePattern.cs`
   - **Description:** Provides a simplified interface to a complex subsystem.

### 12. **State**
   - **File:** `StatePattern.cs`
   - **Description:** Allows an object to change its behavior when its internal state changes.

### 13. **Template Method**
   - **File:** `TemplateMethodPattern.cs`
   - **Description:** Defines the skeleton of an algorithm in the method, deferring some steps to subclasses.

---

## 👤 Author

**Sadık Berkay Karaduman**  
📧 [karadumansadikberkay@gmail.com](mailto:karadumansadikberkay@gmail.com)  
🔗 [GitHub – ParanovaFactory](https://github.com/ParanovaFactory)

---

## 📄 License

MIT License — Feel free to use, modify, and contribute.
