# Traffic Lights - WinForms Traffic Signal Demo

A Windows Forms demo application that simulates a traffic signal controller using custom traffic light controls. The solution switches between four signal phases for two opposing directions and updates the light state with a timer.

## Project Behavior

- The main form hosts four `ctrlTrafficLights` controls.
- Traffic phases cycle in this order:
  1. North/South turns green while East/West is red
  2. North/South turns yellow while East/West remains red
  3. East/West turns green while North/South is red
  4. East/West turns yellow while North/South remains red
- Each phase duration is configured per control using green, yellow, and red timer values.
- The form uses a shared timer (`LightTimer`) to move through the phases automatically.

- `ctrlTrafficLights.cs`
  - Defines a custom user control for an individual traffic light.
  - Supports explicit methods: `MakeLightRed()`, `MakeLightYellow()`, and `MakeLightGreen()`.
  - Uses a local timer to update the light countdown display.
  - Raises events when each light color becomes active.

## Running the Project

1. Open `TrafficLights.sln` in Visual Studio.
2. Build the solution.
3. Run the `Traffic Lights` application.
4. Observe the light states change automatically through red, green, and yellow phases.

## Notes

- Light durations are currently hardcoded in `ctrlTrafficLights`.
- The demo is intended to show WinForms custom controls, timer-based state changes, and basic traffic signal phase sequencing.
