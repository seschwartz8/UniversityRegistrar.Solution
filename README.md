# University Registrar

#### C#/.NET MVC website that allows students and administrators to keep records on courses and student enrollment.

#### By Sarah "Sasa" Schwartz, Andrew Philpott

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [User Stories](#user-stories)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Description

C#/.NET MVC website that allows students and administrators to keep records on courses and student enrollment. This application allows you to create students and courses, and adjust student enrollment in each course. The website will prompt you to register an account and log in to view students and courses. This project focuses on using .NET Core MVC, Authentication, SQL databases/Migration, and one-to-many/many-to-many design for databases.

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the UniversityRegistrar.Solution directory, within the root directory
- \$dotnet restore
- Recreate our database structure with migration:
  - \$dotnet ef migrations add Initial
  - \$dotnet ef database update
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## User Stories

- As a registrar, I want to enter a student, so I can keep track of all students enrolled at this University. I should be able to provide a name and date of enrollment.
- As a registrar, I want to enter a course, so I can keep track of all of the courses the University offers. I should be able to provide a course name and a course number (ex. HIST100).
- As a registrar, I want to be able to assign students to a course, so that teachers know which students are in their course. A course can have many students and a student can take many courses at the same time.
- As a registrar, I want to be able to create departments. A student can be assigned to a department when they declare their major and a course can be assigned to a department when it is created.
- As a registrar, I want to be able to list out all of the courses or all of the students in a particular department, so that I can inform the counselors which departments need more students and which need more courses.
- As a registrar, I want to change a student's file to show that they have completed a course, so that I can see if they need to take the course again.
- As a registrar, I want to list out all of the courses a student has taken, so that I can see if they have met their degree requirements.
- As a registrar, I want to see how many students have not completed courses in any particular departments, so that I can tell the administration which departments need help.
- As a registrar, I want to all courses on the course page and within the department pages ordered alphabetically.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
