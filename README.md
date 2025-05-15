README Documentation
Farmer Product Management System
Technology Stack: ASP.NET Core MVC, C#, Entity Framework Core, SQL Server
Development Environment: Visual Studio Code
1. Project Overview
This prototype represents a core component of a farmer-product management system. It demonstrates how relational data can be effectively managed using an MVC framework with role-based access for Farmers and Employees.
2. Folder Structure
- Models/ – Contains data models: Farmer.cs, Product.cs, and User.cs.
- Controllers/ – Includes controllers for handling logic: FarmerController, EmployeeController, ProductController, AccountController.
- Views/ – Razor views for displaying content per user role.
- Data/ – Contains ApplicationDbContext for managing database interactions via Entity Framework Core.
3. User Roles and Functionality
Farmer
- Secure login
- Add new products (name, category, production date)
- View own product listings
Employee
- Secure login
- Add new farmer profiles with essential information
- View all farmers and their products
- Filter products by category and production date range
4. Database Integration
- Built with SQL Server and connected using Entity Framework Core
- Relational schema to manage Users, Farmers, and Products
- Sample data preloaded for demonstration
Database Initialization:
dotnet ef database update
5. Running the Application
To run the prototype locally:
1. Open the folder in Visual Studio Code
2. Restore dependencies:
dotnet restore
3. Run the application:
dotnet run
4. Open your browser and go to: https://localhost:5001
6. Validation and Error Handling
- Frontend and backend validation to ensure data integrity (e.g., required fields, date formats)
- Role-based authorization implemented
- Graceful error handling to prevent crashes
7. User Interface Design
- Clean, intuitive layout using Razor views
- Responsive design compatible with desktop and mobile
- Easy navigation per role with clear labels and buttons
8. Sample Login Credentials
Role	Email	Password
Farmer	farmer@test.com	Farmer@123
Employee	employee@test.com	Employee@123
9. Development and Testing
- Developed iteratively with regular testing of each feature
- UX testing conducted with sample users to improve interface
- Code is organized and documented for easy maintenance
This document serves as a guide for understanding, running, and evaluating the prototype. All required features have been implemented to reflect a functional and practical solution.
