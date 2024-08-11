# Animal Behavior Modeling

This repository contains a simple implementation of animal behavior modeling in C#.

## Overview

The project consists of the following classes:
- `Animal`: An abstract class representing basic animal properties and behaviors.
- `Cat`: A class representing a cat, inheriting from `Animal` and implementing the `Land` interface.
- `Dog`: A class representing a dog, inheriting from `Animal` and implementing the `Land` interface.
- `Frog`: A class representing a frog, inheriting from `Animal` and implementing the `Land` and `Water` interfaces.
- `Land`: An interface defining the method to get the number of legs for land animals.
- `Water`: An interface defining methods to check if an animal has gills and lays eggs.

## Usage

The project creates an array of animals, including cats, dogs, and frogs, initializes them with different moods, and then displays their information and greets them based on their mood.

## How to Run

To run the project, simply clone the repository, open it in your preferred C# IDE, and run the program. Make sure you have the necessary dependencies installed.

## Contributors

- Avigail Haineman


## UML Diagram

+-----------------------------+
| <<abstract>> Animal          |
+-----------------------------+
| - mammals: bool              |
| - carnivorous: bool          |
| - mood: int                  |
+-----------------------------+
| + sayHello(): void           |
| + sayHello(mood: int): void  |
| + ToString(): string         |
+-----------------------------+

              ▲
              |
+-------------+-----------------------+
|             |                        |
|             |                        |
|             |                        |
| +-----------------------------+      +-----------------------------+
| |          Cat                 |      |           Dog               |
| +-----------------------------+      +-----------------------------+
| | - NumberOfLegs: int          |      | - NumberOfLegs: int          |
| +-----------------------------+      +-----------------------------+
| | + sayHello(): void           |      | + sayHello(): void           |
| | + getNumberOfLegs(): int     |      | + getNumberOfLegs(): int     |
| +-----------------------------+      +-----------------------------+

              |
              |
              ▼

+-----------------------------+
|           Frog               |
+-----------------------------+
| - NumberOfLegs: int          |
+-----------------------------+
| + sayHello(): void           |
| + HasGills(): bool           |
| + HasLaysEggs(): bool        |
| + getNumberOfLegs(): int     |
+-----------------------------+

+-----------------------------+
|           <<interface>> Land |
+-----------------------------+
| + getNumberOfLegs(): int     |
+-----------------------------+

+-----------------------------+
|           <<interface>> Water|
+-----------------------------+
| + HasGills(): bool           |
| + HasLaysEggs(): bool        |
+-----------------------------+
