<p align="center">
	<a href="https://github.com/GwGibson/IOT1026-Assignment-1/actions/workflows/ci.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-1/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/GwGibson/IOT1026-Assignment-1/actions/workflows/formatting.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-1/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/GwGibson/IOT1026-Assignment-1" > 
    <img src="https://codecov.io/gh/GwGibson/IOT1026-Assignment-1/branch/main/graph/badge.svg?token=JS0857X5JD"/>
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>

# IOT1026-Assignment-1

The project focuses on implementing a TreasureChest class that represents a treasure chest with different states and properties. The TreasureChest class utilizes a state machine to manage the transitions between its states, which include Open, Closed, and Locked.

The TreasureChest class has the following key components:

State Management: The class maintains an internal state variable _state to keep track of the current state of the chest. The state can be Open, Closed, or Locked. The state is initially set to Locked by default.

Constructors: The class provides different constructors to instantiate a TreasureChest object. There is a default constructor that sets default values for the material, lock type, and loot quality of the chest. There is also a parameterized constructor that allows the state, material, lock type, and loot quality to be specified during object creation.

State Manipulation: The Manipulate method takes an Action as a parameter and updates the state of the chest based on the provided action. The supported actions include Open, Close, Lock, and Unlock. Depending on the current state of the chest, the corresponding private methods (Open, Close, Lock, Unlock) are called to update the state accordingly.

Private Methods: The class provides private methods to perform specific state transitions. The Open method opens the chest if it is closed and not locked. The Close method closes the chest if it is open. The Lock method locks the chest if it is closed. The Unlock method unlocks the chest if it is locked.

ToString Method: The ToString method is overridden to provide a string representation of the TreasureChest object. It displays the current state and the properties of the chest, including the material, lock type, and loot quality.

The project also includes a testing component that utilizes unit tests to verify the functionality of the TreasureChest class. The provided test cases cover various state transitions, including valid and invalid actions.

![image](https://github.com/diljitehg/IOT1026-Assignment-1/assets/131228332/3c0cacf2-91d0-40f8-91ff-0c787234d5a5)

        
        
[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
