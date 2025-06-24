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
- Secure login with role-based access  
- Add new agricultural product entries:
  - Product name
  - Product category (e.g., Vegetables, Grains, Livestock)
  - Production date  
- View personal product history and details  

### 🧑‍💼 Employee
- Secure login with administrative privileges  
- Register new farmer profiles with demographic and account data  
- Access a list of all registered farmers  
- View products associated with any farmer  
- Filter product data by:
  - Product category
  - Production date range  

---

## Architectural Design

### 📁 Project Structure

```
├── Models/              # Data models: Farmer.cs, Product.cs, User.cs
├── Controllers/         # Business logic controllers
├── Views/               # Razor pages for UI (grouped by role)
├── Data/                # ApplicationDbContext and DB configuration
├── Migrations/          # EF Core migration history
├── wwwroot/             # Static assets (CSS, JS)
├── Program.cs           # App startup configuration
├── appsettings.json     # Connection strings and environment settings
└── README.md            # Documentation
```

### 🧠 Key Design Decisions

- **Role-based Authorization** using ASP.NET Identity  
- **Relational Data Models** connecting Farmers and Products  
- **Scalable Architecture** prepared for analytics, API integration, and additional roles  
- **Validation** via data annotations and UI logic  

---

## Database Schema Overview

- `Users`: Authentication credentials and roles  
- `Farmers`: Farmer-specific information  
- `Products`: Tied to individual farmers via foreign keys  
- Relationships are enforced using Entity Framework Core with a normalized schema  

---

## Installation & Setup Instructions

### Requirements

- .NET 6.0 SDK or higher  
- SQL Server (LocalDB or Express edition)  
- Visual Studio Code (with C# plugin) or Visual Studio 2022+  

### Steps to Run

1. Open the solution folder in Visual Studio or Visual Studio Code  
2. Restore project dependencies  
3. Apply database migrations to initialize the schema  
4. Run the application and navigate to:  
   `https://localhost:5001`

---

## Sample Login Credentials

| Role     | Email                | Password     |
|----------|----------------------|--------------|
| Farmer   | farmer@test.com      | Farmer@123   |
| Employee | employee@test.com    | Employee@123 |

---

## Validation & Security

- Built-in form validation for all user input  
- Backend model validation using `[Required]`, `[StringLength]`, `[DataType]`, etc.  
- Role-based access control ensures each user accesses only permitted features  
- Passwords stored securely using ASP.NET Identity encryption  

---

## User Interface Design

- Razor Views with clean, semantic HTML  
- Responsive layout optimized for both desktop and mobile  
- Navigation and UI elements adapt based on login role (Farmer vs. Employee)  
- Designed with accessibility and clarity in mind  

---

## Testing and Quality Assurance

- Developed iteratively using Agile methodology  
- Functionality tested during and after implementation  
- Manual UX testing done with sample users  
- Code is modular, commented, and follows SOLID principles where applicable  

---

## Limitations and Future Work

- Currently supports only two user roles  
- No analytics, reporting, or API endpoints included yet  
- Future improvements may include:
  - Integration with a renewable energy product marketplace  
  - IoT sensor compatibility for smart farming  
  - Grant application tracking and notifications  
  - Admin dashboards and visual reports  

---

## Educational Context

This project was created for submission in the **PROG7311** module offered by **The Independent Institute of Education (IIE)**. The primary objective was to demonstrate practical competency in:

- Full-stack web application development  
- Secure, role-based data access  
- Database integration and object-relational mapping  
- Agile development and documentation standards  

---
## AI Declaration
OpenAI’s ChatGPT was used to assist with the development of the Agri-Energy Connect farmers’ prototype. It supported the project by helping to draft and refine documentation, explain technical concepts, and align the work with academic outcomes. It was used to help with some css, debugging and helping me learn how to implement certain requirements.

---
## Author & Contact

**Veeasha Packirisamy**  
Student ID: ST10397833  
Module: PROG7311  
Academic Year: 2025  

---

