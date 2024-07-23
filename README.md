# Quiz Application

Welcome to the Quiz Application! This application allows users to take multiple-choice quizzes on various topics, receive immediate feedback, and view their scores. This README provides instructions on how to run and use the application.

## Table of Contents

1. [System Requirements](#system-requirements)
2. [Installation](#installation)
3. [Running the Application](#running-the-application)
4. [Using the Application](#using-the-application)
   - [Selecting a Quiz](#selecting-a-quiz)
   - [Taking a Quiz](#taking-a-quiz)
   - [Viewing Results](#viewing-results)
   - [Retaking a Quiz](#retaking-a-quiz)
5. [Troubleshooting](#troubleshooting)
6. [Contributing](#contributing
7. [License](#license)

## System Requirements

- Operating System: Windows 10 or higher
- .NET 8.0 Runtime
- 2GB RAM minimum
- 100MB free disk space

## Installation

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/GasanaJr/quiz-application.git
   cd quiz-application
   ```
2. **Build the Application**:
    Open the solution file `QuizApp.sln` in Visual Studio.
    Build the solution by selecting `Build > Build Solution`.

## Running the Application (For Developers)

1. **Run the Application**
- In Visual Studio, set `QuizApp` as the startup project.
- Run the application by pressing `F5` o selecting `Debug > Start Debugging`.

## Running the Application (For Non-Developers)

1. **Run the Application**:
- Simply run the `QuizApp.exe` which is the executable file for the application.

## Using the Application

### Selecting a Quiz

#### Select a Quiz:

- From the dropdown menu or list of available quizzes, click on the quiz you want to take.

#### Start the Quiz:

- Click the `Start Quiz` button to begin the selected quiz.

### Taking a Quiz

#### Question Display:

- The first question of the quiz will be displayed along with multiple answer options.

#### Select an Answer:

- Click on the radio button next to the answer option you believe is correct.

#### Confirm Answer:

- Click the `Confirm` button to submit your answer.

#### Feedback:

- After confirming your answer, immediate feedback will be provided, indicating whether your answer is correct or incorrect.
- The next question will be displayed automatically.

#### Proceed to Next Question:

- Repeat the process of selecting an answer and confirming it until all questions are answered.

### Viewing Results

#### Completion:

- Once you have complete` the quiz, your score will be displayed in the format `Your score: X/Y = Z%`, where X is your score, Y is the total possible score, and Z is the percentage.

#### Review:

- You can review the questions and your answers if the application provides such functionality.

### Retaking a Quiz

#### Retake Quiz:

- If you wish to retake the quiz, click the "Retake Quiz" button.

#### Start Again:

- The quiz will reset, and you can start again from the first question.


## Troubleshooting

### Common Issues

#### Application Not Starting:

- Ensure your system meets the minimum requirements.
- Reinstall the application if necessary.
- Check for any pending Windows updates and install them.

#### Quiz Not Loading:

- Ensure you have selected a quiz from the dropdown menu.
- Restart the application and try again.

#### Incorrect Feedback:

- Ensure you have selected an answer before clicking "Confirm".
- If the issue persists, raise an issue on GitHub

## Contributing

We welcome contributions! Please follow these steps:

-  Fork the repository.
-  Create a new branch (`git checkout -b feature/your-feature-name`).
-  Make your changes.
-  Commit your changes (`git commit -m 'Add some feature'`).
-  Push to the branch (`git push origin feature/your-feature-name`).
-  Open a pull request.


Thank you for using the Quiz Application. We hope you have an enjoyable and educational experience!



