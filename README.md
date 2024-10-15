# TCS Event Bus

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)
![Discord](https://img.shields.io/discord/1047781241010794506)

![GitHub Forks](https://img.shields.io/github/forks/Ddemon26/TCS-Event-Bus)
![GitHub Contributors](https://img.shields.io/github/contributors/Ddemon26/TCS-Event-Bus)
![GitHub Stars](https://img.shields.io/github/stars/Ddemon26/TCS-Event-Bus)
![GitHub Repo Size](https://img.shields.io/github/repo-size/Ddemon26/TCS-Event-Bus)

## Overview

The **TCS Event Bus** is a robust, event-driven system designed to handle inter-component communication in C# and Unity environments. It enables decoupled communication by allowing components to react to events without knowing about each other, promoting modular, maintainable code.

The Event Bus allows the creation and dispatching of events asynchronously and with performance optimizations, ensuring scalability.

## Features

- **Decoupled Communication**: Facilitate communication between components with minimal dependencies.
- **High Performance**: Batches event processing for large-scale event handling.
- **Event Binding**: Easily bind handlers to events with or without arguments.
- **Extensibility**: Implement custom events using the `IEvent` interface.
- **Example Implementations**: Provided example scripts for a smooth learning curve.

## Core Files

- **`EventBus.cs`**: The main class responsible for registering, deregistering, and dispatching events. Includes optimizations for handling large numbers of event bindings.
- **`EventBinding.cs`**: Manages the binding between events and their handlers, supporting both events with arguments and events without arguments.
- **`IEvent.cs`**: A simple interface that all custom events must implement.
- **`SampleEvents.cs`**: Defines example events such as `TestEvent` and `PlayerEvent` for demonstration purposes.

## Getting Started

### 1. Install

To install the Event Bus in your project, copy the contents of the `Runtime` folder into your Unity or C# project.

### 2. Define a Custom Event

Custom events need to implement the `IEvent` interface. Here's how to define a simple event:

```csharp
public struct MyCustomEvent : IEvent
{
    public string Data;

    public MyCustomEvent(string data)
    {
        Data = data;
    }
}
```

### 3. Register an Event Handler

You can register event handlers that will be triggered when a specific event is raised. Here’s an example of registering a handler for a `MyCustomEvent`:

```csharp
EventBus<MyCustomEvent>.Register(new EventBinding<MyCustomEvent>(
    onEvent: OnMyCustomEvent
));

private void OnMyCustomEvent(MyCustomEvent e)
{
    Debug.Log($"Received event with data: {e.Data}");
}
```

### 4. Raise an Event

To raise an event and notify all registered handlers:

```csharp
EventBus<MyCustomEvent>.Raise(new MyCustomEvent("Hello from EventBus!"));
```

### 5. Clear Event Bindings

To clear all handlers for a specific event:

```csharp
EventBus<MyCustomEvent>.Clear();
```

### 6. Example with Predefined Events

The system includes predefined events, such as `PlayerEvent`, which includes player health and mana:

```csharp
EventBus<PlayerEvent>.Register(new EventBinding<PlayerEvent>(
    onEvent: OnPlayerEvent
));

private void OnPlayerEvent(PlayerEvent playerEvent)
{
    Debug.Log($"Player Health: {playerEvent.Health}, Mana: {playerEvent.Mana}");
}

EventBus<PlayerEvent>.Raise(new PlayerEvent(health: 100, mana: 50));
```

## Benchmarks

The repository includes a benchmarking tool (`EventBusBenchmark.cs`) to test the performance of the event system under various loads. You can run these benchmarks to ensure the system fits your performance needs.

```csharp
var benchmark = new EventBusBenchmark();
benchmark.Run();
```

## Contributing

We welcome contributions to the TCS Event Bus! Please feel free to open issues, submit pull requests, and join our community discussions on [Discord](https://discord.gg/knwtcq3N2a).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for more details.