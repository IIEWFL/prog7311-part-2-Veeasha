# Agri-Energy Connect – Farmer Product Management Prototype

## Project Title
**Farmer Product Management System (Prototype)**  
Part of the Agri-Energy Connect digital ecosystem – developed for PROG7311.

## Technology Stack
- **Framework**: ASP.NET Core MVC  
- **Language**: C#  
- **ORM**: Entity Framework Core  
- **Database**: SQL Server  
- **Development Tool**: Visual Studio Code  

## Project Description
This prototype serves as a foundational component of the Agri-Energy Connect platform. It demonstrates how agricultural data—specifically products managed by farmers—can be captured, stored, and displayed through a secure, role-based web interface. Built using the Model-View-Controller (MVC) pattern, the application supports two user roles: **Farmers** and **Employees**, each with tailored access to the system.

The prototype emphasizes user authentication, relational data integrity, and role-specific functionality. It simulates real-world interactions between farmers, agricultural support employees, and the platform, forming the base for a scalable digital agriculture and renewable energy integration tool.

## Features by User Role

### Farmer
- Login with a secure farmer account.
- Add new agricultural products, including name, category, and production date.
- View a personal list of products submitted.

### Employee
- Login with employee credentials.
- Register new farmer profiles by capturing essential details.
- View all farmers and their products.
- Filter product data by category and production date range.

## Application Architecture
- **Models**: Define core data structures (Farmer, Product, User).
- **Controllers**: Handle business logic and route user requests appropriately.
- **Views**: Razor Pages render dynamic HTML based on user role and data.
- **Database**: SQL Server stores relational data for products, users, and farmers.
- **Entity Framework Core**: Manages database operations through the `ApplicationDbContext`.

## Setup Instructions

### Requirements
- .NET 6.0 SDK or higher
- SQL Server (local instance or container)
- Visual Studio Code or Visual Studio 2022+

### Running the Project
1. Clone or download the project.
2. Open the project folder in Visual Studio Code.
3. Restore dependencies:
dotnet restore

lua
Copy
Edit
4. Apply migrations and create the database:
dotnet ef database update

markdown
Copy
Edit
5. Run the application:
dotnet run

markdown
Copy
Edit
6. Open your browser at:
https://localhost:5001

pgsql
Copy
Edit

## Sample Login Credentials

| Role     | Email                | Password     |
|----------|----------------------|--------------|
| Farmer   | farmer@test.com      | Farmer@123   |
| Employee | employee@test.com    | Employee@123 |

## Validation and Error Handling
The application includes both server-side and client-side validation for input fields (e.g., required fields, date formats). It uses ASP.NET Core Identity for secure login and enforces role-based access restrictions. Errors are handled gracefully to ensure a smooth user experience and prevent application crashes.

## User Interface Design
The user interface was developed using Razor Views and Bootstrap styling to ensure responsive layouts. The design supports both desktop and mobile usage. Farmers and employees each access distinct views that match their permissions and intended workflows.

## Testing and Development Approach
The application was built iteratively using Agile principles. Core features were developed and tested individually, with emphasis on user experience. Feedback from test users was incorporated to improve navigation, layout clarity, and data visibility.

## Conclusion
This prototype meets the core objectives for the Agri-Energy Connect proof of concept. It demonstrates a functional, secure, and extendable system for managing farmers and their agricultural products. Future iterations will include expanded role support, analytics dashboards, and integration with green energy project modules.

## Author
**Veeasha Packirisamy**  
Student ID: ST10397833  
Module: PROG7311 – Enterprise Software Development  
Submission Year: 2025
