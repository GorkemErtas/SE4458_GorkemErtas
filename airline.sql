CREATE DATABASE airline_db;
USE airline_db;

CREATE TABLE Flights (
    `from` VARCHAR(255) NOT NULL,
    `to` VARCHAR(255) NOT NULL,
    available_dates TEXT NOT NULL,
    days_of_week TEXT NOT NULL,
    capacity INT NOT NULL
);

CREATE TABLE Tickets (
    flight_id INT NOT NULL,
    passenger_name VARCHAR(255) NOT NULL,
    is_checked_in BOOLEAN DEFAULT FALSE
);

CREATE TABLE Passengers (
    full_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL
);

