# XO Game - WinForms Tic-Tac-Toe

A Windows Forms implementation of the classic Tic-Tac-Toe game with a 3x3 board, turn-based play, and win/draw detection.

## Project Overview

This app provides a simple two-player Tic-Tac-Toe experience using button controls for each board cell. Players take turns placing X and O markers until one wins or the board fills.

## Features

- 3x3 grid board using WinForms buttons
- Alternating player turns (Player 1 = X, Player 2 = O)
- Move validation to prevent overwriting cells
- Win detection across:
  - Rows
  - Columns
  - Diagonals
- Draw detection when all cells are filled without a winner
- Visual highlight for the winning line
- Restart button to reset the board and gameplay state

## How It Works

- The current player is tracked with an enum (`enPlayer`).
- Each cell button stores its state in `Tag` and updates its image on click.
- After each move, the app checks all winning combinations.
- If a winner is found, the winning buttons are highlighted and the game ends.
- If all nine moves are played without a winner, the game ends in a draw.

## Running the Project

1. Open `XOGame.sln` in Visual Studio.
2. Build the solution.
3. Run the application.
4. Click any empty cell to place X or O.
5. Use the restart button to play again.

## Notes

- No undo or game history feature is currently implemented.
- The UI uses resource images for X, O, and the default placeholder.
