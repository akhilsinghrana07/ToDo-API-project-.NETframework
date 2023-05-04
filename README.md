# ToDo-API-project-.NETframework

This is a sample ToDo API built with C# and .NET Framework, which can be run using Docker. The API provides endpoints to manage a list of tasks that need to be completed, allowing users to create, read, update, and delete tasks.

## Getting Started
To get started, you will need to have Docker installed on your machine. You can download Docker from the official website.

Once you have Docker installed, you can build and run the ToDo API using the following commands:

## Docker command Code

docker compose-up

This will build a Docker image for the ToDo API and start a container running the API on port 8080. You can then access the API by navigating to http://localhost:8080/api/tasks in your web browser or using a tool like Postman to send HTTP requests to the API endpoints.

## API Endpoints
The following API endpoints are available for managing tasks:

GET /api/tasks: Returns a list of all tasks.

POST /api/tasks: Creates a new task with the specified name and description.

GET /api/tasks/{id}: Returns the task with the specified ID.

PUT /api/tasks/{id}: Updates the task with the specified ID with the new name and description.

DELETE /api/tasks/{id}: Deletes the task with the specified ID.

## Contributing
If you would like to contribute to this project, feel free to submit a pull request with your changes. We welcome contributions of all kinds, including bug fixes, new features, and improvements to the documentation.
