# Pool Club - WinForms Pool Table Tracker

A Windows Forms demo app that tracks play time and calculates fees for multiple pool tables.

## Features

- Custom pool table user control with:
  - Start / Stop timer button
  - Play time
  - End button to compute total charge
- Fee calculation based on an hourly rate
- Aggregated play completion event handling
- Multiple table controls on a single form
- Simple UI for monitoring time usage and fees

## Files of Interest

- `frmPoolClub.cs` - Main form that hosts the pool table controls.
- `ctrlPool.cs` - Custom user control implementing the timer and billing logic.
- `Program.cs` - Application entry point.
- `Pool Club.csproj` - Project file.

## Running the Project

1. Open `Pool Club.sln` in Visual Studio.
2. Build the solution.
3. Run the `Pool Club` project.
4. Use the table controls to start and end play sessions.
