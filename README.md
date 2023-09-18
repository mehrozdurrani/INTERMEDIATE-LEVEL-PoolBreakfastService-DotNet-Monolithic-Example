# PoolBreakfast Service Example

Welcome to the PoolBreakfast service example project! This project is designed for educational purposes to demonstrate how to implement a basic CRUD (Create, Read, Update, Delete) service for managing breakfast data. It also showcases the usage of "ErrorOr" library for global exception and error handling, along with invariants.

## Project Overview

This repository serves as a valuable resource for anyone interested in learning about the following topics:

- Building a simple CRUD application.
- Global exception and error handling with "ErrorOr."
- Applying invariants to ensure data integrity.

## JSON Request and Responses

### Create Breakfast
**POST {host}/Breakfast**

```json
{
    "name": "Vegan Sandwich",
    "description": "Vegan everything! Join us for a healthy breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```
### Get Breakfast by ID
**GET {host}/breakfast/{id}**

### Update Breakfast
**PUT {host}/breakfast/{id}**
```json
{
    "name": "Total Sunshine Omlette",
    "description": "Wonderful dish to enjoy",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```
### Delete Breakfast
**DELETE {host}/breakfast/{id}**

## Usage
Feel free to explore the code in this repository to understand how the PoolBreakfast service is implemented. You can use this project as a reference to learn about CRUD operations, global exception handling, and invariants in software development.

## Getting Started
To get started with this project, follow these steps:

- Clone the repository to your local machine.
- Build and run the project using your preferred development environment.
- Use the provided API endpoints to interact with the breakfast service.

## Contribution
This project is not open for contribution yet most welcome to clone and use it.

## Contact
If you have any questions or suggestions, feel free to contact me at mehrozdurrani@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE](https://opensource.org/license/mit/) file for details.

Happy learning and coding!