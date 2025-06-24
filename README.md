# Agri-Energy Connect – Farmer Product Management System (Prototype)

## Project Title
**Farmer Product Management System**  
A role-based agricultural data management prototype built for the Agri-Energy Connect platform as part of the PROG7311 Practical Assignment.

---

## Technology Stack

- **Frontend & View Engine**: Razor Views (ASP.NET Core MVC)
- **Backend Language**: C# (.NET 6.0)
- **Framework**: ASP.NET Core MVC
- **ORM (Database Access)**: Entity Framework Core
- **Database**: Microsoft SQL Server
- **IDE**: Visual Studio Code (or Visual Studio 2022+)
- **Authentication**: ASP.NET Identity (Role-based authentication)

---

## Project Overview

This prototype represents the core module of a larger envisioned ecosystem, **Agri-Energy Connect**, which aims to bridge South African agriculture with renewable energy solutions.

The module simulates real-world data management by allowing two types of authenticated users—**Farmers** and **Employees**—to perform role-specific operations. Farmers can manage their own products, while Employees have administrative access to farmer records and broader visibility across the platform. The design leverages the **Model-View-Controller (MVC)** pattern and is built with scalability and modularity in mind.

This prototype serves as the foundation for broader platform features such as a green energy marketplace, sustainability resources, and funding collaboration tools.

---

## Functional Requirements Implemented

### 👨‍🌾 Farmer
- Secure login with role-based access.
- Add new agricultural product entries, including:
  - Product name
  - Product category (e.g., Vegetables, Grains, Livestock)
  - Production date
- View personal product history and details.

### 🧑‍💼 Employee
- Secure login with administrative privileges.
- Register new farmer profiles with basic demographic and account information.
- Access a list of all registered farmers.
- View products associated with any farmer.
- Apply filters to view products based on:
  - Product type
  - Production date range

---

## Architectural Design

### 📁 Project Structure

├── Models/ # Data models: Farmer.cs, Product.cs, User.cs
├── Controllers/ # Business logic controllers
├── Views/ # Razor pages for UI (grouped by role)
├── Data/ # ApplicationDbContext and DB configuration
├── Migrations/ # EF Core migration history
├── wwwroot/ # Static assets (CSS, JS)
├── Program.cs # App startup configuration
├── appsettings.json # Connection strings and environment settings
└── README.md # Documentation

markdown
Copy
Edit

### 🧠 Key Design Decisions
- **Role-based Authorization**: Implemented using ASP.NET Identity to ensure clean separation of concerns.
- **Entity Relationships**: Products are tied to Farmers, and Users are associated with one of the two roles.
- **Validation**: Built-in model validation and Razor form validation to enforce input correctness.
- **Scalability**: The system is designed to support future modules (analytics, IoT integration, funding alerts).

---

## Database Schema Overview

- `Users` (base table for authentication)
- `Farmers` (extends users with domain-specific fields)
- `Products` (foreign key to Farmers)
- Relationships enforced through Entity Framework with code-first migrations

### Sample Command to Apply Migrations:
```bash
dotnet ef database update
Installation & Setup Instructions
Prerequisites
.NET 6.0 SDK

SQL Server (LocalDB, Express, or containerized instance)

Visual Studio Code (with C# and EF Core extensions) or Visual Studio 2022+

Run Instructions
Clone or download the repository.

Open the folder in Visual Studio Code or Visual Studio.

Restore all dependencies:

bash
Copy
Edit
dotnet restore
Apply migrations and create the database:

bash
Copy
Edit
dotnet ef database update
Run the application:

bash
Copy
Edit
dotnet run
Navigate to:

arduino
Copy
Edit
https://localhost:5001
Sample Login Credentials
Role	Email	Password
Farmer	farmer@test.com	Farmer@123
Employee	employee@test.com	Employee@123

Validation & Security
Input Validation: Enforced through Data Annotations ([Required], [StringLength], [DataType], etc.)

Security:

Passwords are hashed and stored securely.

Users are authenticated via cookie-based login.

Role-based access control ensures unauthorized access is prevented.

User Interface Design
Built using Razor Pages with Bootstrap for layout and styling.

Fully responsive: optimized for both desktop and mobile use cases.

UI routes and navigation menus adjust dynamically based on user role.

Error feedback and field hints included to improve usability and reduce data entry mistakes.

Testing and Quality Assurance
Features were developed and tested iteratively using Agile principles.

Manual testing was performed for:

Data creation and retrieval workflows

Authentication and role restrictions

Form validation and error states

Code is logically structured and includes XML comments for maintainability.

Limitations and Next Steps
While this prototype fulfills core CRUD functionality, the following features are planned for future iterations:

Integration with a green energy product marketplace.

Farmer dashboard with analytics and summaries.

Support for funding application modules.

RESTful API endpoints for mobile or third-party integration.

Full deployment pipeline using Docker and CI/CD tools (e.g., GitHub Actions).

Educational Context
This project was developed as part of the PROG7311 module for submission to The Independent Institute of Education (IIE) in 2025. The prototype was built to demonstrate competence in:

MVC architecture

Secure database integration

Enterprise software design patterns

Agile and DevOps alignment

Practical UI/UX implementation

Author & Contact
Veeasha Packirisamy
Student ID: ST10397833
Module: PROG7311 – Enterprise Software Development
Submission Year: 2025
