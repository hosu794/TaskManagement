# Simple Task Management System

This project is a simple task management system designed to help users manage their tasks effectively. The system distinguishes between two types of users: basic users (employees) and managers.

## Table of Contents

- [Description](#description)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Database Schema](#database-schema)
- [Testing](#testing)
- [Assumptions](#assumptions)
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

## Features

- User roles: Basic Users and Managers
- CRUD operations on tasks
- Task sharing between users
- Managers can view subordinates' tasks
- Monthly task statistics view for managers
- Stored procedure for task statistics

## Installation

1. Clone the repository:
   ```bash
   git clone <repository-link>
   ```
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string in `appsettings.json`.
4. Build and run the solution.

## Usage

### WinForms Application

- **Login**: Enter credentials to log in as either a basic user or a manager.
- **Task Management**: Create, update, delete, and view tasks.
- **Statistics (Manager only)**: View task statistics by month.

### REST API

- **Endpoints**:
  - `GET /tasks`: Retrieve all tasks.
  - `GET /tasks/{id}`: Retrieve a specific task.
  - `POST /tasks`: Create a new task.
  - `PUT /tasks/{id}`: Update an existing task.
  - `DELETE /tasks/{id}`: Delete a task.
  - `GET /statistics`: Retrieve task statistics (Manager only).

## Database Schema

The database schema includes the following tables:

- **Users**: Stores user information (ID, name, role).
- **Tasks**: Stores task information (ID, header, priority, description, user ID).
- **TaskShares**: Stores information about task sharing between users (task ID, user ID).

## Testing

Sample tests are provided to verify the functionality of the system. The tests cover:

- CRUD operations for tasks
- User access control
- Task sharing
- Statistics calculation

Run the tests using the Visual Studio Test Explorer.

## Assumptions

- User authentication and authorization are simplified for this task.
- The system assumes that tasks are always created by authenticated users.
- Task sharing functionality is implemented by copying the task reference to the shared user.

## Further Work

- Implement a more robust authentication and authorization mechanism.
- Enhance the UI/UX of the WinForms application.
- Add more comprehensive tests, including edge cases and performance testing.
- Optimize the database schema for large datasets.
- Implement notification features for task updates and shares.

## Architectural Decisions

- **Entity Framework**: Chosen for its simplicity and ease of use for database operations.
- **WinForms**: Selected for a simple and quick user interface implementation.
- **REST API**: Provides a clean separation between the UI and business logic, enabling potential future expansion to other types of clients (e.g., web, mobile).
- **In-Memory Storage Option**: Allows for quick setup and testing without the need for a full SQL Server instance.

**Note**: The feature to display shared comments was implemented, but not fully completed.

Feel free to explore the code and provide feedback or contribute to the project.