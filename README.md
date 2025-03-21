# FacultyFlex - Faculty Management Software

FacultyFlex is a Windows Forms Application built using **C# and MySQL** to streamline **faculty workload management** and **resource allocation** at the **Department of Computer Science, UET Lahore**. The system replaces inefficient manual processes with a **centralized, role-based platform**, ensuring better workload distribution, faculty request tracking, and improved department planning.

---

## 📌 Features

### 🔐 User Authentication & Role Management
- Secure **login system** with **hashed passwords**.
- **Role-based access control (RBAC)** for department head, faculty members, and administrative staff.
- **Forgot password & account recovery system**.

### 🏫 Faculty Management
- **Add, update, delete faculty profiles**.
- Store faculty details (**Name, Designation, Research Interests, Teaching Hours**).
- Assign faculty roles from **predefined lookup values**.

### 📚 Workload Assignment
- Assign **courses** to faculty members **per semester**.
- Manage **final-year projects and research supervision**.
- Track **administrative duties** (e.g., committees, coordination).

### 🏢 Resource Allocation
- Assign **classrooms and labs** to faculty members.
- Manage faculty requests for **board markers, stationery, and consumables**.
- Allow faculty members to **track request status**.

### ✅ Faculty Requests Management
- Faculty members can request **resources** (board markers, lab space, stationery).
- Requests can be **approved, rejected, or marked as fulfilled**.
- Track **inventory of consumables** to ensure timely procurement.

---

## 🛠️ Tech Stack
- **C# .NET (Windows Forms)**
- **MySQL Database**
- **BCrypt.Net** for **password hashing**
- **Singleton Pattern** for database operations
- **Role-Based Authentication System**

---

## 🚀 Installation Guide

1. **Clone the Repository**  
   ```sh
   git clone https://github.com/HafizMMoaz/DBS25P023.git
   cd DBS25P023

2. **Set Up Database**
    - Import database_schema.sql into MySQL.
    - Update DB.cs with your MySQL credentials.
    - Run the Project

    - Open DBS25P023.sln in Visual Studio.
    - Build and run the project.

    ```sh
    private readonly string serverName = "127.0.0.1";
    private readonly string port = "3306"; 
    private readonly string databaseName = "midprojectdb";
    private readonly string databaseUser = "root";
    private readonly string databasePassword = "YourPasswordHere";

3. **Run the Project**
    - Open DBS25P023.sln in Visual Studio.
    - Build and run the project.


## 📝 To-Do (Remaining Work)

- ✅ Core features are implemented! However, a few tasks remain:
- 🛒 Consumables Inventory Management (track available resources).
- 👥 Multi-User Feature Distribution (better handling of simultaneous logins).
- 📜 Faculty Request Fixes (some requests are not being processed correctly).
- 🗓️ Faculty Course Scheduling (automated timetable generation).
- 📜 Database Creation through Software