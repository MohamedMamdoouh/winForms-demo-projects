# Pizza Order - WinForms Pizza Ordering Demo

A Windows Forms pizza ordering demo app that lets users select pizza size, crust type, toppings, and dine-in or takeout options while calculating the total price.

## Project Overview

The app provides a lightweight order form with:

- Pizza size selection (small, medium, large)
- Crust type selection (thin or thick)
- Multiple optional toppings
- Eat-in or takeout selection
- Real-time order summary and total price calculation
- Order confirmation and form reset behavior

## Features

- Size pricing based on selected radio button
- Crust pricing based on selected crust type
- Toppings pricing adds dynamically as checkboxes change
- Eat-in and eat-out selection affects the order details
- Total price is updated automatically whenever options change
- Order confirmation disables the form after a successful order
- Reset button restores default values

## Key Logic

- `UpdateSizePrice()` sets the selected size price
- `UpdateCrustTypePrice()` sets the selected crust price
- `UpdateToppongsPrice()` calculates topping costs from selected checkboxes
- `UpdateTotalPrice()` aggregates all selected option prices
- `UpdateToppings()` builds a human-readable toppings list
- `DisableAfterConfirmOrder()` locks the order form after confirmation

## Running the Project

1. Open `PizzaOrder.sln` in Visual Studio.
2. Build the solution.
3. Run the application.
4. Select pizza size, crust, toppings, and dine-in or takeout.
5. Click `Order Pizza` to confirm or `Reset` to restart.

## Notes

- Default state is Small pizza, Thin crust, Eat In, and no toppings.
- The app is designed for learning WinForms form handling, control events, and simple pricing logic.
