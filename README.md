# 🎨 Tent City Studio Event Bus

![Unity](https://img.shields.io/badge/Unity-2022.3+-black.svg?style=for-the-badge&logo=unity)
![Contributions welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=for-the-badge)
[![Odin Inspector](https://img.shields.io/badge/Odin_Inspector-Required-blue?style=for-the-badge)](https://odininspector.com/)

***
![Banner Image](https://via.placeholder.com/1000x300.png?text=assets+TCS+Event+Bus+for+Unity)
***

![GitHub Forks](https://img.shields.io/github/forks/Ddemon26/TCS-Event-Bus)
![GitHub Contributors](https://img.shields.io/github/contributors/Ddemon26/TCS-Event-Bus)

![GitHub Stars](https://img.shields.io/github/stars/Ddemon26/TCS-Event-Bus)
![GitHub Repo Size](https://img.shields.io/github/repo-size/Ddemon26/TCS-Event-Bus)

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)
![Discord](https://img.shields.io/discord/1047781241010794506)

![GitHub Issues](https://img.shields.io/github/issues/Ddemon26/TCS-Event-Bus)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr/Ddemon26/TCS-Event-Bus)
![GitHub Last Commit](https://img.shields.io/github/last-commit/Ddemon26/TCS-Event-Bus)

![GitHub License](https://img.shields.io/github/license/Ddemon26/TCS-Event-Bus)
![Static Badge](https://img.shields.io/badge/Noobs-0-blue)

✨ **TCS Event Bus** is a Unity tool designed to facilitate event-driven programming by providing a robust event bus system. It allows for easy registration, deregistration, and raising of events, making it simple to manage event-driven logic in your Unity projects.

![Demo GIF](https://media.giphy.com/media/l4Ep6KDbnTvdhGMP6/giphy.gif)

## 📜 Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [Installation](#installation)
- [Usage](#usage)
- [Customization](#customization)
- [Contributing](#contributing)
- [License](#license)

## ✨ Features

- **Event Registration**: Easily register and deregister event handlers.
- **Event Raising**: Raise events and handle them asynchronously.
- **Batch Processing**: Efficiently process large numbers of event handlers in batches.
- **Cancellation Support**: Cancel event processing on application quit.

## 🚀 Getting Started

Follow these steps to start using the **TCS Event Bus**:

1. **Install Dependencies**: Ensure that [Odin Inspector](https://odininspector.com/) is installed, as it is required for custom editor features.

2. **Open the Event Bus**: In Unity, navigate to `Tools > Event Bus` to open the tool's editor window.

3. **Initialize Systems**: Set up the event bus system in your game scene.

4. **Register Events**: Use the provided scripts to register and handle events.

## 🔧 Installation

1. Clone or download this repository.
2. Add the folder to the `Assets` directory in your Unity project.
3. Install [Odin Inspector](https://odininspector.com/).
4. Open the Unity Editor and access the Event Bus through the `Tools` menu.

## 🛠️ Usage

1. **Event Registration**: Use the `EventBus<T>` class to register and deregister event handlers.
2. **Event Raising**: Use the `Raise` method in the `EventBus<T>` class to raise events.
3. **Batch Processing**: The event bus automatically processes large numbers of event handlers in batches for efficiency.
4. **Cancellation Support**: The event bus supports cancellation of event processing on application quit.

## ⚙️ Customization

- **Custom Event Types**: Define new event types by implementing the `IEvent` interface.
- **Batch Size**: Adjust the batch size for event processing in the `EventBus<T>` class.
- **Cleanup Threshold**: Customize the cleanup threshold for pending removals in the `EventBus<T>` class.

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature/NewFeature`).
3. Make your changes and commit (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature/NewFeature`).
5. Open a pull request.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.