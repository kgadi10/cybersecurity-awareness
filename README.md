# Cybersecurity Awareness Chatbot

## Project Overview

The Cybersecurity Awareness Chatbot is a GUI-based C# application designed to educate users about cybersecurity and help them stay safe online.

The chatbot provides interactive conversations, cybersecurity tips, task management, reminders, quizzes, and activity tracking.

The application was developed using C# Windows Forms and Object-Oriented Programming principles.

---

## Features Implemented

### 1. Chatbot Interaction
- User-friendly graphical interface
- Personalised conversations
- Cybersecurity-related responses
- Input validation
- Error handling

### 2. Voice Greeting and Visual Design
- Voice greeting plays when the application starts
- Cybersecurity themed ASCII logo
- Console/GUI formatting and design elements

### 3. Keyword Recognition
The chatbot recognises cybersecurity keywords including:
- Password
- Phishing
- Scam
- Privacy
- Two-factor authentication

The bot provides advice based on recognised topics.

---

### 4. Random Responses

The chatbot uses multiple responses for cybersecurity topics to make conversations more natural.

---

### 5. Memory Feature

The chatbot stores user information such as:
- User name
- Favourite cybersecurity topic

The chatbot recalls this information during conversations.

---

### 6. Sentiment Detection

The chatbot detects simple emotions:

- Worried
- Frustrated
- Curious

The chatbot responds with supportive cybersecurity guidance.

---

### 7. Task Assistant

Users can manage cybersecurity tasks.

Features:
- Add tasks
- Add reminders
- View tasks
- Complete tasks
- Delete tasks

Example tasks:
- Enable two-factor authentication
- Update passwords
- Review privacy settings

---

### 8. Database Integration

A MySQL database is used to store tasks.

Database table:
Tasks

Stored information:
- Task ID
- Title
- Description
- Reminder date
- Completion status

---

### 9. Cybersecurity Quiz

The chatbot includes a quiz game.

Features:
- 10+ cybersecurity questions
- Multiple choice questions
- True/False questions
- Immediate feedback
- Score tracking

---

### 10. NLP Simulation

Natural Language Processing is simulated using string manipulation.

The chatbot understands different user commands such as:

"Add a task"
"Remind me to update my password"
"Show activity log"

---

### 11. Activity Log

The chatbot records important actions:

- Tasks created
- Reminders added
- Quiz activity
- User commands

Users can view recent activity.

---

## Technologies Used

- C#
- Windows Forms
- Object-Oriented Programming
- MySQL Database
- GitHub
- GitHub Actions

---

## How To Run The Application

1. Install Visual Studio
2. Install MySQL Server
3. Create the CyberBot database
4. Open the project
5. Build the solution
6. Run the application

---

## Database Setup

Create database:

CREATE DATABASE CyberBot;

Create Tasks table:

CREATE TABLE Tasks
(
Id INT AUTO_INCREMENT PRIMARY KEY,
Title VARCHAR(100),
Description VARCHAR(255),
ReminderDate DATE,
Completed BOOLEAN
);

---

## GitHub Actions

Continuous Integration was implemented using GitHub Actions.

The workflow automatically checks that the project builds successfully after commits.

A successful run is shown with a green check mark.

---

## Author

Cybersecurity Awareness Chatbot Project
