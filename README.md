```markdown

🌾 Farmer Product Management System – Agri-Energy Connect Prototype
Built with ASP.NET Core MVC | C# | Entity Framework Core | SQL Server

📘 Project Overview
This prototype forms the foundation of a Farmer Product Management System for the broader Agri-Energy Connect platform. It showcases how relational agricultural data can be securely managed using the MVC architectural pattern, complete with role-based access control for Farmers and Employees. The goal is to demonstrate the feasibility of scalable, real-world data management and interaction within a green-tech-enabled farming ecosystem.

🧱 Technology Stack
Framework: ASP.NET Core MVC

Language: C#

ORM: Entity Framework Core

Database: SQL Server

IDE: Visual Studio Code

📁 Folder Structure
```
├── Models/ # Entity classes (Farmer.cs, Product.cs, User.cs)
├── Controllers/ # Application logic (FarmerController, EmployeeController, etc.)
├── Views/ # Razor Views per role and function
├── Data/ # Database context (ApplicationDbContext)
├── wwwroot/ # Static files (CSS, JS)
├── Program.cs / Startup.cs
└── appsettings.json # Configuration file
```

👥 User Roles & Features
👨‍🌾 Farmer
🔐 Secure login

➕ Add new product (Name, Category, Production Date)

📄 View personal product listings

🧑‍💼 Employee
🔐 Secure login

➕ Register new farmer profiles

🔍 View all farmers and their products

📊 Filter products by category and production date range

🗄️ Database Integration
Uses Entity Framework Core for database interaction

Backed by SQL Server

Designed with a relational schema for Users, Farmers, and Products

Comes with preloaded sample data for testing

💾 Database Setup
```bash
dotnet ef database update
```

🚀 Running the Application Locally
Make sure .NET 6.0 SDK or higher is installed.

🛠️ Steps:
Open the project in Visual Studio Code

Restore dependencies:
```bash
dotnet restore
```

Run the application:
```bash
dotnet run
```

Navigate to:
https://localhost:5001

✅ Data Validation & Error Handling
✔️ Form validation on both frontend (Razor) and backend (Model attributes)

🔐 Role-based authorization per user type

❌ Graceful error handling prevents system crashes or unauthorized access

🖥️ User Interface Design
Clean and intuitive UI using Razor views

Fully responsive design – accessible on desktop and mobile

Easy-to-navigate layout tailored for each user role

🔐 Sample Login Credentials
Role	Email	Password
Farmer	`farmer@test.com`	`Farmer@123`
Employee	`employee@test.com`	`Employee@123`

🧪 Development & Testing
✔️ Developed iteratively using Agile principles

🧑‍💻 Each module tested upon implementation

🧪 UX tested with mock users to improve usability

📝 Well-commented and organized codebase

📄 License & Attribution
This prototype was developed as part of the PROG7311 POE submission for academic purposes.
All rights reserved © 2025 – The Independent Institute of Education (Pty) Ltd.

🙋‍♀️ Maintainer
Veeasha Packirisamy
Student ID: ST10397833
Module: PROG7311 – Enterprise Software Development
```


