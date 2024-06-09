# Charge Management Application

This is a Windows Form application built in C# that helps manage the charging of a laptop battery. The application monitors the battery level and provides notifications to connect or disconnect the charger based on configurable high and low setpoints.

![Screen](https://github.com/aliyaghoobi88/Charge-managment/assets/4157568/ba7e6603-efc2-4856-9fed-608e14ce20dc)


## Features

- Monitor battery level and power line status
- Display battery percentage remaining and power line status
- Configure high and low setpoints for battery percentage
- Connect to an Ethernet Relay (not implemented) to control power plug
- Notification balloons to remind the user to connect or disconnect the charger
- Minimize the application to the system tray
- Save and load user settings

## Usage

1. Run the application.
2. Configure the high and low setpoints for the battery percentage in the Condition group box.
3. Optionally, configure the IP address and port for the Ethernet Relay in the Relay Setting group box (not implemented).
4. Click the Save button to save the settings.
5. The application will monitor the battery level and power line status.
6. When the battery level reaches the high setpoint while the power line is online, a notification balloon will appear, reminding the user to disconnect the charger.
7. When the battery level drops to the low setpoint while the power line is offline, a notification balloon will appear, reminding the user to connect the charger.
8. Double-click the system tray icon to restore the application window.

## Dependencies

- .NET Framework
- System.Management

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
