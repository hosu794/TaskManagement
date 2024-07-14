# Simple Task Management System

This project is a simple task management system designed to help users manage their tasks effectively. The system distinguishes between two types of users: basic users (employees) and managers.

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Database Schema](#database-schema)
- [Testing](#testing)
- [Further Work](#further-work)
- [Architectural Decisions](#architectural-decisions)

## Description

The system allows users to:
- Add, edit, and delete tasks.
- Access their tasks and tasks shared by others.
- Managers can view tasks of their subordinates.
- View task statistics by month.

Each task includes:
- Header
- Priority
- Description

Tasks are stored in a SQL Server database, with an option to use in-memory storage for simplicity. Entity Framework is used for data access. The application consists of two main components:
1. User Interface (a simple WinForms application)
2. Business Logic (a service exposing a REST API)


## Installation

1. Clone the repository:
   ```bash
   git clone <repository-link>
   ```
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string in `appsettings.json`.
4. Run SQL script in your database.
4. Build and run the solution.

### WinForms Application

The application includes several WinForms to provide a user-friendly interface for different functionalities:

### ChooseManagerForm.cs

This form allows users to select a manager. 
- A new user is being assigned to a manager
- An existing user's manager is being changed

### EditForm.cs

This form is used for editing existing tasks. 
- Text fields for task title and description
- Dropdown for priority selection
- Save and Cancel buttons

### LoginRegisterForm.cs

This form serves dual purposes for user authentication:
-  Login: For existing users to access the system
-  Register: For new users to create an account
- Toggle between login and register modes


### MainForm.cs

This is the primary interface of the application after login.
- A list or grid view of the user's tasks
- Buttons for creating new tasks, editing, and deleting existing ones
- Navigation to other forms (like ChooseManagerForm or ManagerStatsForm)
- Logout functionality

### ManagerStatsForm.cs

This form is specific to users with manager roles.
- Statistical overview of tasks assigned to team members

### ShareTask.cs

This form facilitates the sharing of tasks between users.
- Choose user to share task

Each of these forms contributes to different aspects of the task management system, providing a comprehensive user interface for both regular users and managers.

## API Endpoints

This section describes all available API endpoints in the Task Management System.

### Task Controller

- `POST api/Task/tasks`
  - Creates a new task for the logged-in user.
  - Requires authentication.

- `PUT api/Task/tasks`
  - Updates an existing task.
  - Requires authentication.

- `DELETE api/Task/tasks`
  - Deletes a task with the given ID.
  - Requires authentication.

- `POST api/Task/share/task`
  - Shares a task with another user.
  - Requires authentication.

- `DELETE api/Task/shared/tasks`
  - Removes a shared task (not implemented).
  - Requires authentication.

- `GET api/Task/tasks`
  - Retrieves all tasks for the logged-in user.
  - Requires authentication.

- `GET api/Task/shared/tasks/by/user`
  - Retrieves tasks shared by the logged-in user.
  - Requires authentication.

- `GET api/Task/shared/tasks/for/user`
  - Retrieves tasks shared with the logged-in user.
  - Requires authentication.

- `GET api/Task/tasks/managers`
  - Retrieves tasks of subordinates for the logged-in manager.
  - Requires authentication and manager role.

- `GET api/Task/tasks/manager/stats`
  - Retrieves task statistics of subordinates for the logged-in manager.
  - Requires authentication and manager role.

### Priority Controller

- `GET api/Priority/priorities`
  - Retrieves a list of all priorities.

### User Controller

- `POST api/User/register`
  - Registers a new user.

- `POST api/User/login`
  - Authenticates a user.

- `GET api/User/manager`
  - Checks manager authorization (managers only).
  - Requires authentication and manager role.

- `GET api/User/current`
  - Retrieves data for the currently logged-in user.
  - Requires authentication.

- `GET api/User/user/exists`
  - Checks if a user with the given username exists.

- `GET api/User/all`
  - Retrieves a list of all users.

- `PUT api/User/managers`
  - Assigns a manager to a user.
  - Requires authentication.

- `GET api/User/managers`
  - Retrieves a list of all managers.
  - Requires authentication.

Most endpoints require authentication, and some are accessible only to users with the manager role. The system uses role-based access control to manage access to different functionalities.

## Database Schema

The database schema consists of the following tables and relationships:

1. **Priority**
   - `id` (int, primary key)
   - `name` (varchar(100))

2. **User**
   - `id` (int, primary key)
   - `username` (varchar(100))
   - `password` (varchar(300))
   - `managerId` (int, foreign key to Manager)

3. **Manager**
   - `userId` (int, primary key, foreign key to User)

4. **TaskTodo**
   - `id` (int, primary key)
   - `title` (varchar(100))
   - `description` (text)
   - `createdAt` (datetime)
   - `updatedAt` (datetime)
   - `userId` (int, foreign key to User)
   - `priorityId` (int, foreign key to Priority)

5. **SharedTask**
   - `userId` (int, foreign key to User)
   - `Task_id` (int, foreign key to TaskTodo)
   - Composite primary key (userId, Task_id)

## Testing

Due to time constraints, comprehensive testing has not been implemented. This is an area that requires further work to ensure the reliability and robustness of the system.

## Features

- User roles: Basic Users and Managers
- Role-based authorization for users and managers
- CRUD operations on tasks
- Task sharing between users
- Managers can view subordinates' tasks
- Monthly task statistics view for managers
- Stored procedure for task statistics

## Project Structure

The application is divided into four main modules:

1. **Data**: Handles database operations and data persistence.
2. **Frontend**: Contains the WinForms user interface.
3. **Core**: Houses the core business logic and domain models.
4. **API**: Implements the REST API for communication between the frontend and backend.

## Further Work

In addition to the points mentioned earlier:

- Implement comprehensive unit tests and integration tests.
- Improve the task sharing functionality, which is currently not fully developed.
- Refactor and improve code quality. The current implementation needs further optimization and better separation of concerns.
- Enhance error handling and logging throughout the application.
- Implement more robust security measures, especially for user authentication and authorization.

## Architectural Decisions

- **Modular Architecture**: The application is split into Data, Frontend, Core, and API modules to improve maintainability and allow for easier future expansions or modifications.
- **Entity Framework**: Chosen for its simplicity and ease of use for database operations.
- **WinForms**: Selected for a simple and quick user interface implementation.
- **REST API**: Provides a clean separation between the UI and business logic, enabling potential future expansion to other types of clients (e.g., web, mobile).
- **Role-based Authorization**: Implemented to ensure proper access control for users and managers, enhancing system security and functionality segregation.
