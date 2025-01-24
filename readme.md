Library Management System
This Library Management System is a console-based application implemented in C#. It demonstrates key concepts of Object-Oriented Programming (OOP), adherence to SOLID principles, and the use of design patterns such as Singleton and Factory. The program allows users to manage a collection of books and eBooks, enabling operations like adding, removing, searching, and listing items.

Features
Part 1: Basic Functionality
Book Class:

Includes core attributes such as Title, Author, ISBN, and Available.
Provides a constructor to initialize attributes and a ToString method for formatted output.
Library Class:

Manages a collection of books using a list.
Offers methods to:
Add a book.
Remove a book by ISBN.
Search for a book by title.
List all books in the library.
Part 2: Enhanced with OOP Principles
EBook Subclass:

Extends the Book class with an additional FileSize attribute.
Overrides the ToString method to include file size details.
LibraryManager Class:

Provides a menu-driven interface for user interactions.
Contains methods for handling input and executing library operations.
Part 3: SOLID Principles and Design Patterns
Singleton Pattern:

Ensures a single instance of the LibraryManager class globally manages user interactions.
Factory Pattern:

Introduces the BookFactory class to streamline the creation of Book and EBook objects.
Enhances scalability by separating object creation logic from core application logic.
Application of SOLID Principles:

Single Responsibility Principle (SRP):
Each class has a clear, single responsibility:
Book and EBook: Represent book entities.
Library: Manages the collection of books.
LibraryManager: Facilitates user interaction.
BookFactory: Handles object creation.
Open/Closed Principle (OCP):
The Book class is open for extension (via EBook) but closed for modification.
Liskov Substitution Principle (LSP):
Objects of the EBook subclass can replace Book objects without altering program behavior.
Interface Segregation Principle (ISP):
Methods are specific to each class's purpose, maintaining clarity and simplicity.
Dependency Inversion Principle (DIP):
The LibraryManager depends on abstractions (Library and BookFactory), not concrete implementations.
How to Run
Set Up the Environment
Install Visual Studio or any other C# IDE.
Ensure the C# SDK is installed.
Download and Extract
Download the project ZIP file.
Extract the contents into a folder of your choice.
Open the Project
Open Visual Studio.
Navigate to File > Open > Project/Solution.
Select the .csproj file from the extracted folder.
Run the Program
Set Program.cs as the startup file.
Build the solution (Ctrl + Shift + B) to verify there are no compilation errors.
Run the program (F5 or click the green play button).
Interacting with the Program
Use the text-based menu to:
Add new books or eBooks.
Remove books by their ISBN.
Search for books by title.
List all books in the library.
Follow on-screen instructions for a seamless experience.
Technical Details
Classes and Design
Book:
Represents a physical book with attributes like Title, Author, ISBN, and availability status.
EBook:
Extends Book with an additional FileSize property.
Library:
Manages a collection of Book and EBook objects.
LibraryManager:
Implements the user interface and orchestrates operations using the library and factory classes.
BookFactory:
Handles the creation of Book or EBook objects based on user input.
Design Patterns
Singleton:
Ensures only one instance of LibraryManager exists to manage interactions.
Factory:
Simplifies object creation, making the system easier to extend.
SOLID Principles in Action
SRP: Each class has a dedicated responsibility.
OCP: The system is easily extendable for new features without altering existing code.
LSP: Subclasses can replace base classes seamlessly.
ISP: Clear, concise methods specific to class roles.
DIP: High-level modules depend on abstractions, not implementations.
Future Enhancements
Add support for user accounts and book lending/returning.
Implement a graphical user interface (GUI) for enhanced usability.
Add persistence using a database or file storage.
Enjoy exploring and managing your library!

Let me know if you need further adjustments!
