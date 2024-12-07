# High Score Game

This is a **Windows Forms Application** written in C# that allows users to register, log in, and play a simple game where they increment their score by clicking a button. The scores are tracked for each user in memory.

---

## Features

1. **User Registration**:
   - New users can register by providing a username.
   - The application prevents duplicate usernames.

2. **User Login**:
   - Existing users can log in using their registered username.
   - Upon login, the current user's score is loaded and displayed.

3. **Simple Game**:
   - Once logged in, the user can play a game where they increment their score by clicking a button.
   - The score is updated in real-time and saved for the current session.

---

## Code Overview

### Main Components:
- **User Management**:
  - Usernames and scores are stored in a 2D string array `users`.
  - Maximum of 100 users can be registered.
- **Game Logic**:
  - `button_click_add_point`: Increments the logged-in user's score.
  - Scores are saved for each user and displayed on the interface.

### UI Elements:
- **TextBoxes**:
  - `textBox_register`: For entering a username to register.
  - `textBox_login`: For entering a username to log in.
- **Labels**:
  - `label_current_user`: Displays the currently logged-in user.
  - `label_int_score`: Displays the user's current score.
- **Buttons**:
  - `button_register`: Registers a new user.
  - `button_Log_In`: Logs in an existing user.
  - `button_play`: Enables the game.
  - `button_click_add_point`: Adds a point to the user's score.

---

## How to Run

1. Open the project in **Visual Studio**.
2. Build and run the application.
3. Use the following steps to interact with the app:
   - Register a new user by entering a username and clicking the **Register** button.
   - Log in as an existing user using the **Log In** button.
   - Click the **Play** button to start the game.
   - Click the **Add Point** button to increment your score.

---

## Known Limitations

- **Session-Based Storage**: 
  - User data (usernames and scores) are stored in memory. Closing the application will reset the data.
- **Fixed User Limit**:
  - A maximum of 100 users can be stored due to the static array size.

---

## Future Improvements

- Implement persistent storage (e.g., using a database or file system) to save user data between sessions.
- Enhance the UI for a better user experience.
- Add error handling for edge cases (e.g., logging in as a non-registered user).
- Introduce new gameplay features to make the game more engaging.
- implement modules

---

## Dependencies

- **.NET Framework** (for Windows Forms Application).

