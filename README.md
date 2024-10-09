# TCS Event Bus

![GitHub release (latest by date)](https://img.shields.io/github/v/release/Ddemon26/TCS-Event-Bus)
![GitHub](https://img.shields.io/github/license/Ddemon26/TCS-Event-Bus)
![GitHub issues](https://img.shields.io/github/issues/Ddemon26/TCS-Event-Bus)
![GitHub pull requests](https://img.shields.io/github/issues-pr/Ddemon26/TCS-Event-Bus)
![GitHub last commit](https://img.shields.io/github/last-commit/Ddemon26/TCS-Event-Bus)

## Overview

**TCS Event Bus** is a sophisticated and highly flexible event bus framework, implemented in **C#** for **Unity** environments, designed to facilitate efficient event management across different modules of a Unity project using the **publish-subscribe** paradigm. This package aims to significantly improve the decoupling of components, thereby reducing rigid dependencies and enhancing overall system modularity.

The **TCS Event Bus** empowers developers to broadcast messages and register for event notifications in an entirely decoupled manner, eliminating the need for direct, hard-coded references among objects. Such capabilities render it particularly advantageous for large-scale Unity applications where scalability and maintainability are paramount.

## Features

- **Decoupled Communication**: Facilitates a robust communication architecture that obviates direct object references, promoting a more modular system design.
- **Minimalist & Intuitive API**: Offers a streamlined, developer-friendly interface that minimizes the learning curve and accelerates the integration process.
- **Scalability**: Designed to support both small and large-scale projects with optimal performance, ensuring negligible system overhead.
- **Unity Integration**: Seamlessly integrates with Unity's Assembly Definition files, allowing precise separation of runtime and testing assemblies, thereby optimizing project organization and performance.

## Getting Started

### Prerequisites

- **Unity 2019.4 or later**: The package is compatible with Unity version 2019.4 and subsequent versions.
- **.NET Standard 2.0**: Ensure that your Unity project targets **.NET Standard 2.0** or a later version.

### Installation

To incorporate **TCS Event Bus** into your Unity project, perform the following steps:

1. Clone the repository or download it as a ZIP archive.
2. Extract and place the **TCS Event Bus** folder within your Unity project's `Assets/` directory.
3. Confirm that the **TCS.EventBus.asmdef** is appropriately referenced within your project's assembly definitions to maintain modular integrity.

Alternatively, utilize Unity's Package Manager to include this repository as a dependency, particularly if it is hosted on GitHub.

### Usage

1. **Define an Event**: Implement the `IEvent` interface to define a new event type.

   ```csharp
   public class PlayerScoredEvent : IEvent
   {
       public int PlayerID { get; set; }
       public int Score { get; set; }
   }
   ```

2. **Subscribe to an Event**: Utilize the `EventBus` to subscribe to a specific event type.

   ```csharp
   EventBus.Subscribe<PlayerScoredEvent>(OnPlayerScored);

   private void OnPlayerScored(PlayerScoredEvent e)
   {
       Debug.Log($"Player {e.PlayerID} scored {e.Score} points!");
   }
   ```

3. **Publish an Event**: Use the `EventBus` to publish an instance of the event.

   ```csharp
   var scoreEvent = new PlayerScoredEvent { PlayerID = 1, Score = 10 };
   EventBus.Publish(scoreEvent);
   ```

### Examples

Concrete examples illustrating the usage of **TCS Event Bus** are available in the **Test/EventBusExample.cs** file. This file demonstrates a variety of use cases, including event subscription and event publication patterns.

## Testing

The **Test** directory contains comprehensive unit and benchmark tests aimed at verifying the reliability and efficiency of the event bus framework. Specifically, `EventBusBenchmark.cs` facilitates performance assessment under different load conditions, thereby offering insights into the event bus's efficiency.

To execute the tests:

1. Open the Unity Test Runner via `Window > General > Test Runner`.
2. Ensure that both **PlayMode** and **EditMode** tests are configured appropriately.
3. Run all available tests to validate the robustness and stability of the **TCS Event Bus** implementation.

## Contributing

Contributions are highly encouraged! If you have recommendations for new features or identify a bug, please create an issue or submit a pull request.

### Contribution Guidelines

- Ensure that all new contributions are thoroughly covered by appropriate unit tests.
- Adhere to the existing code conventions and organizational structure.
- Document all changes in the **CHANGELOG.md** to maintain transparency and version history.

## License

This project is distributed under the **MIT License**. For more information, refer to the [LICENSE](./LICENSE) file.

## Contact

For inquiries or feedback, you are encouraged to open an issue on GitHub or reach out directly to the repository maintainer.

---

We appreciate your interest in **TCS Event Bus**! We are confident that it will enhance the modularity and maintainability of your Unity projects.
