# OOP-Mini-Projects
📁 OOP Mid-Term Lab Projects — Overall Description A collection of three C# console-based applications developed as  Mid-Term Lab Tasks for BS Software Engineering OOP course. Each  project demonstrates core Object-Oriented Programming concepts  including encapsulation, classes, constructors, methods, input  validation, and static members.


🎓 OOP Projects 
A collection of three C# console-based applications developed as Mid-Term Lab Tasks for the Object-Oriented Programming course. Each project demonstrates core OOP concepts including encapsulation, classes, constructors, methods, input validation, and static members.

📁 Projects Overview
#ProjectDescription1🏦 Smart Banking Account SystemManage bank accounts with deposit & withdrawal2🏃 Personalized Health TrackerTrack fitness sessions and workout stats3📚 Academic Record AnalyzerManage student marks and calculate grades

🏦 1. Smart Banking Account System
Description
A console-based banking application where the Bank class manages individual accounts. Supports deposit and withdrawal operations with proper input validation.
Features

Create bank accounts with name, account number, age, and balance
Deposit funds with negative amount validation
Withdraw funds with invalid amount validation
Display real-time account details after every transaction
Static counter to track total number of accounts created

OOP Concepts Used

Encapsulation (private fields)
Constructors
Static members
Methods with validation

Sample Output
------ Account Details -------
Account Holder : Abubaker
Account Number : 112230
Current Balance : 8500
User Age : 19

........ Amount Deposited Successfully ........
Balance = 9500

........ Amount WithDraw Successfully ........
Balance = 4500

Total Accounts = 1

🏃 2. Personalized Health Tracker System
Description
A fitness tracking application built with two classes — User and Workout. Users can log workout sessions with detailed exercise information.
Features

Store user profile (name, email, birth year, age)
Getter and setter methods for encapsulated fields
Log multiple workout sessions with unique Session ID and date
Track exercise name, calories burned, and duration per session

OOP Concepts Used

Encapsulation (private fields with getters/setters)
Multiple classes
List collections (List<Workout>)
Constructors

Sample Output
----- User Details -----
Name = Abubaker
Age = 19
Session ID = 1
Date = 17-April-2026
    Exercise Name = Push Ups
    Calories =  200
    Duration =  20
    Exercise Name = Bench press
    Calories =  150
    Duration =  15

📚 3. Personalized Academic Record Analyzer
Description
A student grade management system using the StudentRecord class. Stores five subject marks with validation, supports bonus marks, and auto-calculates grades.
Features

Store 5 subject marks in an array
Index and range validation (marks must be 0–100)
Add bonus marks across all subjects
Automatic grade calculation based on final scores

OOP Concepts Used

Encapsulation
Arrays and loops
Constructors with multiple parameters
Input validation logic

Sample Output
Enter Bonus Marks you want to Add : 10
Student Name = Abubaker

Marks = 100
Marks = 81
Marks = 84
Marks = 92
Marks = 96
Grade = A

🛠️ Tech Stack
Language   : C#
Framework  : .NET
Type       : Console Application
Paradigm   : Object-Oriented Programming (OOP)

🚀 How to Run

Clone the repository

bash   git clone https://github.com/your-username/oop-midterm-lab.git

Open the project in Visual Studio or VS Code
Navigate to the desired project folder
Build and run using:

bash   dotnet run



└── README.md
