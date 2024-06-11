# Unreal To Unity Class Selector

A project that bridges the class reference functionality of Unreal Engine with Unity. This system allows developers to select and use class types in the Unity Inspector, similar to Unreal Engine's class reference variable.

## Features

- Select class types from a dropdown in the Unity Inspector.
- Dynamically add selected class types to GameObjects at runtime.
- Simple setup and easy to integrate into existing Unity projects.

## Requirements

- Unity 2022.3.26f1

## Installation

### 1. Clone the Repository

First, clone the repository to your local machine:

git clone https://github.com/yourusername/UnrealToUnityClassSelector.git

### 2. Open the Project:

Open the cloned project in Unity.

## Usage

### 1. Attach the Script to a GameObject

#### Create a GameObject

In your Unity scene, create an empty GameObject or use an existing one.

#### Attach the UClassSelectorExample Script

1. Select the GameObject in the hierarchy.
2. In the Inspector, click on "Add Component".
3. Type `UClassSelectorExample` and select it from the list to attach it to the GameObject.

### 2. Select a Class in the Inspector

#### Open the Inspector

With the GameObject selected, locate the `UClassSelectorExample` component in the Inspector.

#### Select a Class

1. You will see a dropdown menu labeled "Selected U Class".
2. Click on the dropdown menu to view a list of available class types derived from MonoBehaviour.
3. Select a class type from the list.

### 3. Run the Scene

#### Play the Scene

Click the "Play" button in the Unity Editor to run the scene.

#### Check the GameObject

During runtime, the selected class type will be added as a component to the GameObject. You can verify this by inspecting the GameObject in the Inspector during play mode.

## Credits

### Project Creator
- **Kearin L**
  - GitHub: [@Kearinl](https://github.com/Kearinl)
  - Unity3D Game Developer
  - Proficient in: C#, C++, Java, Python



