# Rock, Paper, Scissors Game

## Overview

This is a console application that simulates the classic game of Rock, Paper, Scissors. The game allows a single player to compete against an AI opponent. The AI opponent makes random moves, providing a challenge for the player. The game continues until either the player or the AI reaches 3 points, at which point the final scores are displayed and the winner is declared.

## Features

- Single-player mode against an AI.
- Players take turns choosing their moves (rock, paper, or scissors).
- The game compares the moves of both players and determines the winner of each round.
- Displays the result and updates the scores after each round.
- Handles invalid moves and exceptions during gameplay.
- Ends the game when any player reaches 3 points.

## Program Specifications

### Main Method
- Entry point of the application that initializes and starts the game.

### Player Class
- Represents a player with properties for name and score.
- Contains a method for choosing a move (rock, paper, or scissors).

### RPSGame Class
- Manages the game logic, including comparing moves and determining the winner of each round.
- Contains methods for playing rounds, displaying scores, and managing the game flow.

## How to Run the Application
1. Clone the repository or download the project files.
2. Open the project in C# development environment Visual Studio.
3. Build the project to ensure all dependencies are installed.
4. Run the application. The console will prompt you to enter your name and then start the game.

## How to Play
1. Enter your name when prompted.
2. Choose your move by typing 'ROCK', 'PAPER', or 'SCISSORS' when prompted.
3. The game will display the AI's move, update the scores, and display the result of the round.
4. The game continues until either you or the AI reaches 3 points.
5. The final scores and the winner will be displayed at the end of the game.

## Unit Tests
- Test if the game correctly determines the winner of each round based on the players' moves.
- Test if the game correctly updates the scores after each round.




