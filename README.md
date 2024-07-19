# ToDo-List-Blazor

## Description

ToDo-List-Blazor is a web application built using the Blazor framework, which allows users to create, edit, and delete tasks while managing their daily activities. The application includes user authentication features, such as registration, login, account deletion, and account information updates. Task data is automatically saved to the server database.

## Features

- *Task Management:* Create, edit, delete tasks.
- *Authentication:*
  - User Registration
  - User Login
  - Account Deletion
  - Account Information Update
  - Account Information View
- *Data Handling:* Automatic saving of task data to the server database.
- *Task Fields:* Each task includes the following fields:
  - *Task Name:* The name of the task.
  - *Date:* The due date of the task.
  - *Priority:* The priority level of the task.
  - *Status:* The current status of the task.
  - *Countdown:* Time remaining until the task is due.
  - *Content:* Detailed description of the task.

## Technology Stack

- *Backend:* C#, Blazor framework (Blazor Server).
- *Frontend:* HTML, Bootstrap.

## Getting Started

### Prerequisites

To run this project locally, you will need:

- Visual Studio 2019 or later with the ASP.NET and web development workload
- .NET SDK
- A compatible web browser

### Installation

1. Clone the repository:
```sh
   git clone https://github.com/iazin/ToDo-List-Blazor.git
```  
2. Open the project in Visual Studio:
```sh
   cd ToDo-List-Blazor
```
   Open the solution file (.sln) in Visual Studio.
3. Restore the required packages:
```sh
   dotnet restore
```
4. Build the project:
```sh
   dotnet build
```
5. Run the application:
```sh
   dotnet run
```
6. Open your web browser and navigate to https://localhost:7080 to start using the ToDo-List-Blazor application.

## Usage

1. *Register:* Create an account to access the application features.
2. *Login:* Use your credentials to log in.
3. *Creating a Task:* Click on the "Add Task" button, fill in the task details, and save.
4. *Editing a Task:* Click on the task you want to edit, update the details, and save.
5. *Deleting a Task:* Click on the delete icon next to the task you want to remove.
6. *Account Management:* Access your account information and make any necessary updates.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
