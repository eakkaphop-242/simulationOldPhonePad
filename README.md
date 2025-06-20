# simulationOldPhonePad
This project simulates typing messages using an old mobile phone keypad. Users can input a sequence of key presses, and the program will convert it into a readable message.

## Description
A system that simulates sending text messages on old mobile phones. For example, when you want to send the message 'HI', to send the message character by character, you input the number '44' to get 'H', '444' to get 'I', and when you press '#' it's like sending the message.

## Getting Started

Before installing and running this project, make sure you have the following installed:

- **Operating System**: Windows 10 / macOS / Ubuntu 20.04+
- **.NET SDK**: .NET Core SDK 8.0 or later  
  👉 [Download .NET SDK](https://dotnet.microsoft.com/download)
- **IDE/Text Editor**:  
  - [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (Community Edition or higher)  
    - Required Workloads: `.NET Core cross-platform development`  
  - OR [Visual Studio Code](https://code.visualstudio.com/) with the following extensions:
    - C# (by Microsoft)
    - .NET Install Tool for Extension Authors *(optional)*

- **Git**: For version control and cloning the repository  
  👉 [Download Git](https://git-scm.com/downloads)

You can verify your .NET SDK version by running:
```bash
dotnet --version
```

## Installation

Follow these steps to set up and run the project locally:

**Clone the repository**

```bash
git clone https://github.com/eakkaphop-242/simulationOldPhonePad
```
## Executing program

To run the application from the command line, follow these steps:

**1. Open a terminal window**  
   - In **Visual Studio Code**: press **Ctrl** + **`** or go to *View > Terminal*  
   - In **Visual Studio**: go to *Tools > Terminal* or use the *Package Manager Console*

**2. Navigate to the project directory**

```bash
cd simulationOldPhonePad 
```
**3. Executing**
```bash
dotnet run
```


## Running Tests

To run the tests from the command line, follow these steps:

**1. Navigate to the test project directory**

```bash
cd simulationOldPhonePad.Tests
dotnet test
```



## Help

If you encounter any issues, feel free to:

- Check the [Issues](https://github.com/eakkaphop-242/simulationOldPhonePad) tab to see if the problem has already been reported.
- Create a new issue with a detailed description of the problem.
- Contact the project maintainer at: eakkaphop.pt@gmail.com , ttobas88@gmail.com

## Acknowledgments

Inspiration, code snippets, etc.
* [README-Template.md](https://gist.github.com/DomPizzie/7a5ff55ffa9081f2de27c315f5018afc)
* [Task.Wait Method](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.wait?view=net-9.0)
* [Dictionary<TKey,TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-9.0)
