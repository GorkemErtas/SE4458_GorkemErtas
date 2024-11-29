# AirlineAPI

This project aims to develop a RESTful API for flight management and ticketing operations for an airline company. Admin users can add flights and generate reports, while mobile users can query flights, purchase tickets, and perform check-in operations. The project is developed using .NET Core and PostgreSQL technologies.

## Features

### Admin Operations
- **Add Flight**: `/InsertFlight`
- **Generate Flight Capacity Reports**: `/ReportFlights`

### Mobile User Operations
- **Query Flights**: `/QueryFlights`
- **Buy Ticket**: `/BuyTicket`
- **Check-In**: `/CheckIn`

### Authentication
- **JWT Authentication**: Admin operations are secured using JWT authentication.

### Swagger UI
- **API Documentation**: Swagger UI is integrated for testing and viewing the API documentation.

## API Endpoints

### Admin Operations
- **/InsertFlight**: Allows admin users to add new flights.
- **/ReportFlights**: Allows admin users to view flight capacity reports.

### Mobile User Operations
- **/QueryFlights**: Provides flight query service for users.
- **/BuyTicket**: Allows users to purchase tickets.
- **/CheckIn**: Enables users to check-in for their flights.

### Swagger UI
- Swagger UI can be used to test all APIs and view their documentation.

## Database Design
The project uses the following tables in its database schema:

- **Flight**: Contains flight information.
- **Ticket**: Contains information about purchased tickets.
- **Passenger**: Contains passenger information.

## Technologies Used
- **Backend**: .NET 7 Web API
- **Database**: PostgreSQL
- **Authentication**: JWT
- **API Documentation**: Swagger UI
