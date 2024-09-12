# Vigilance Fire

## Project Overview

The application aims to provide real-time monitoring and management of emergency situations such as gas leaks and temperature irregularities. It allows users to:

- Sign in and access the dashboard.
- Monitor alerts and notifications.
- Check gas levels and temperature.
- Find the nearest safe exit in case of an emergency using AR mode.
- Manage users (administrators only).

## Features

### 1. User Authentication
- A sign-in page for employees and administrators to securely enter their credentials.

### 2. Key Data Display
- Shows real-time data for temperature, gas levels, and alerts via a graphical dashboard accessible by users and administrators.

### 3. Alert Management
- View, handle, and resolve various types of alerts. This feature is available to system administrators.

### 4. Gas and Temperature Monitoring
- Track and display gas tank levels and room temperatures. Administrators are responsible for monitoring these values.

### 5. Emergency Mode
- In the event of an emergency, the system displays the safest exit routes, and evacuation instructions are provided with AR support.

### 6. User Management
- Administrators can add, edit, or delete users from the system, allowing for full control over user access.

## Technologies Used

- **.NET Core 8.0**
- **ASP.NET MVC**
- **Entity Framework Core** (for database handling)

## Usage

### 1. User Authentication
- Employees and administrators must sign in using their credentials.
- Admins have additional privileges such as user management.

### 2. Dashboard
- The main dashboard displays gas levels, temperature, and alerts in real-time.
- Admins can access the emergency mode to find safe exits using augmented reality.

### 3. User Management
- Administrators can add new users, edit existing user details, and delete users from the system.

## Future Work

This project is currently a basic version based on the wireframe. Future improvements could include:

- Adding database integration for user management and alerts.
- Implementing real-time data updates for temperature and gas levels.
- Improving the user interface design.

## How to Use

1. **Sign in** using your credentials.
2. Access the **dashboard** to monitor gas levels and temperature.
3. Respond to **alerts** and manage emergencies through the **alert management** system.
4. In case of an emergency, switch to **Emergency Mode** for evacuation routes.
5. Administrators can manage users in the **User Management** section.

## License

This project is licensed under the MIT License.