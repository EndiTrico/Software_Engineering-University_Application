# SUNY - University Management System

## Project Overview
- After various deliberations between the team members, we decided that for our Visual Basic course, we will be developing a university application designed to assist students and professors in their operations. Specifically, our application is going to be developed for the State University of New York (SUNY), which has been a partner to UNYT for years.
- The reason we have chosen to develop such a program is because we have noticed a necessity to enable professors, students, as well as administration staff to have concise, precise data in real-time. Having this data available through our application, all these entities will be able to conduct their operations much more effortlessly. As mentioned, since our application would be dedicated to SUNY students and staff, the users that would interact with this system are:</br>
  1. Admin</br>
  1. Professors</br>
  1. Students</br>
  
- Inside the app, each of these users will have their own respective display with the list of options consisting of all their possible functionalities, designed to aid their day-to-day activities.
- Firstly, it is crucial to highlight the fact that before each of the actors accesses their own respective list of options, they are required to select their role, thus whether they are a student, professor, or admin. Once the actor has picked their role, they can proceed onto the next step: the log in.
- For all the users, no matter what their selected role is, in order to make use of their own functionalities, they need to first login by using their credentials: username and password. After the credentials are provided, a validation step is conducted to ensure that the data is correct. In the case of incorrect credentials, an error message-box would be displayed and the user will be prompted to reenter their credentials. Lastly, after effectively completing the login step, the usersare navigated to their respective list of options, where they can choose whatever operation to conduct.

## Project Management
- As mentioned in our previous section, we will be developing a university application designed to assist students and professors in their operations specifically for the State University of New York (SUNY). After considering various software process models, we have chosen to move forward with the incremental model. The incremental model in software development is an iterative approach to building software, where the development process is divided into smaller modules. Each module goes through the same stages of the software development life cycle, namely requirements gathering, design, development, testing and deployment. The reasons behind this decision are due to the numerous advantages that this process model offers. More specifically:
  - <b>Flexibility</b> → The incremental model allows for more flexibility in the development process, as each increment can be developed independently of the others. This means that we can easily accommodate change during the software development process, even after the requirements have been specified in the initial phase.
  - <b>Prompt validation and response</b> → Since every module goes through the whole software development lifecycle, it enables us to receive immediate validation and feedback on the software we have already developed for the client, which, in turn, aids us in detecting bugs and issues much earlier in the development cycle, where it’s easier to solve them.
  - <b>Rapid delivery and deployment</b> → The clients are able to use the desired software as early as possible, even with initial modules, if these modules provide the basic requirements.</br></br>

<div align = "center">
  <img src="https://github.com/EndiTrico/Visual_Basic-University_Application/assets/85561383/aede26e1-af4b-45f4-867c-5d22a96eccb9">
  <h4><em>Figure 1: Incremental Model for SUNY</em></h4>
</div>

## Functional and Non-Functional Requirements
### Functional Requirements
- Functional requirements are a type of requirement that specify what a system should do to meet the user or customer's needs. In terms of our application, they describe the system's features, inputs and outputs, and behavior in different scenarios. For our software development process, its’s necessary to document requirements to ensure that the final draft they meet user needs and are delivered on time. Our functional requirements are as follows:</br>

<b>Administrator should be able to:</b>
- Add professor to the university’s databank of university of employees.
- Enrolls student into university.
- Add course to the university’s databank of university courses.
- Remove professor from the university’s databank of university of employees.
- Unenroll student from university.
- Remove course from the university’s databank of university courses.
</br>

<b>Professor should be able to:</b>
- Add the grades of the students for the course that he/she selected.
- Show all the students registered in the course that he/she selected.
- Show the names of all students who are passing a specific course.
- Show to see the names of all students who are failing a specific course.
- Show the score average for the course that he/she has selected.
- Show the student with the highest score for the course that he/she selected.
- Show the student with the lowest score for the course that he/she selected.
</br>

<b>Student should be able to:</b>
- Enroll in one of the courses/classes that the university is offering.
- Drop one of the courses/classes that he/she is currently enrolled into.
- Show the courses that he/she is enrolled into the university.
- Show all the available courses that the university offers.
- Show the grades that he/she has taken in the courses that he/she has been enrolled.
- Show his/her GPA.
- Show the number of credits for the courses that he/she is currently enrolled in the university.
- Show the number of credits for each course available in the university.
- Save his/her academic transcript on his/her computer as a text file in a special folder.

### Non-Functional Requirements
- Non-functional requirements describe the qualities that a system should possess in order to meet certain criteria, however they are not directly related to the system's functional requirements.
In our application, we have highlighted the following non-functional requirements:

  - <b>Intuitive and attractive UI</b>
    - It is important for our application that the UI design is easy to understand and use, without requiring extensive training or instructions for the prospective users. This includes using a clear and concise language, as well as a logical and consistent layout for all functionalities. As such we have specified the following requirement for this:
        1. The application should have an appropriate, clear, and grammar error-free label next to every input and output displayed.
        2. The application should follow the same color scheme throughout all its functionalities regardless of the actor currently using the application.

  - <b>Security</b>
    - As our application will handle sensitive data from the University’s database, including information about the students and professors, it is important to implement a good security mechanism, including authentication, authorization, and data integrity.
      1. If the user tries authenticating with a correct username and password, however with an incorrect role chosen, he should be displayed an error message indicating an error in role selection and not allowed to proceed further into the application.
      2. If the user tries authenticating with a mismatching username or password, he should be displayed an error message indicating an error in credentials and not allowed to proceed further into the application.
      3. All application data will be stored in a secure local database, which includes firewallsto restrict unauthorized access.

  - <b>Availability</b>
    - It is very crucial for our application to be operational and accessible to users. As such we have specified the following requirements for this:
      1. Between 07 AM and 11 PM in any day, the total system down time should not exceed 10 minutes.
      2. Between 07 AM and 11 PM in any day, the recovery time after a system failure should not exceed 3 minutes.
      3. Between 11 PM and 07 AM in any day, the total system down time should not exceed 30 minutes.

  - <b>Responsiveness</b>
    - In terms of responsiveness, our application should react to user inputs and commands with great to the speed and efficiency. As such we have specified the following requirements for this:
      1. After the user performs an action on the application, such as a button click, th appropriate display should be updated within 0.2 seconds.
      2. The application display time after user authentication has been validated should not exceed 10 seconds.


## UML Diagrams
### Class Diagrams

- Class Diagrams describe the structure of our system: University System Application, by showing the system's classes, their attributes, operations, and the relationships among these objects.
</br></br>

<div align = "center">
  <img src="https://github.com/EndiTrico/Software_Engineering-University_Application/assets/85561383/baeff855-0dbd-4053-a051-d7ad9666de91">
  <h4><em>Figure 2: Class Diagrams of SUNY Application</em></h4>
</div>

#### Classes Description

<b>1. Login (Interface)</b>
- In our university system application, we have included the Login interface, which does not have any attributes, but it has one method, or operator, called: <em>isUsernameAndPasswordValid()</em>.
- This method serves with the purpose of verifying if whether the username and/or password entered by the user are valid or not. The Login interface is implemented by the Professor and Student Class.
</br></br>

<b>2. Admin (Class)</b>
- The Admin Class, is one of the most important classes of our application because it handles some of the basic processes of our application which are: Add/Remove Student, Add/Remove Professor and Add/Remove Courses.
- These processes, also represent some of the methods of this class. Other methods that this class has are:
  - <em>isUsernameAndPasswordValid()</em>, which validate if the given credentials are valid;
  - <em>readDatabase()</em>, which reads the database of students, professors, and courses tables.
- So, every change, being that addition or removal that Admin does, affects the professor’s, course’s class, and student’s class.
- What is more, the Admin Class also includes other attributes, which are <em>username, password, professorList, studentList, and coursesList</em>.
</br></br>

<b>3. Person (Abstract Class)</b>
- The Person Class represents the abstract class of our system application and that is why it is written in Italic format.
- In addition, Professor and Student Classes are the children of the Person Class, because they inherit the properties of the Person class, while the Person Class which represents the properties that are inherited from the children’s classes, is known as parent class (base class, superclass class).
- The Person Class includes four attributes, respectively <em>id, name, surname, username and password</em>, whose data type is string except of id which is of type integer; and it also has an operator (method) called ToString(), which displays the five attributes listed above.
</br></br>

<b>4. Professor (Class)</b>
- The Professor Class is another important class on this application, because it handles all the functionalities of the Professor user.
- As I previously mentioned in the Person Class, it represents one of the children’s classes of the Person Class, because it inherits all the properties of the Person Class, but it has also additional methods some of which are:
  - <em>isUsernameAndPasswordValid()</em>, which is implemented from the Login interface; addGrades(), which adds the grade for every student of the Professor’s class;
  - <em>showFailingStudents() and showPassingStudents()</em>, which show the students that have passed or failed the course that the professor teaches;
  - <em>showAverage()</em>, which shows the average score of the class;
  - <em>showMaxGrade() and showMinGrade()</em>, which display the student with the maximum or minimum grade, etc..
- In addition, despite of inheriting the attributes of the Person’s Class which are: <em>id, name, surname, username and password</em>, it also three other attributes, which are: <em>courses, and coursesIds</em> of List <string> type, <em>activeCourse</em> of string type, <em>activeCourseId</em> of type integer, and lastly <em>loggedProfessor</em> of List <Professor> type.
</br></br>

<b>5. Student (Class)</b>
- The Student Class as in the case of the Professor represent an important class, because it handles all the functionalities of the student user.
- The other children of the Person Class, which inherits all its properties, is the Student Class.
- Some additional methods of the Student’s Class are:
  - <em>isUsernameAndPasswordValid()</em>, which is implemented from the Login interface;
  - <em>enroll()</em>, which makes it possible for a student to enroll in a course;
  - <em>drop()</em>, which allows the student to drop a course, exit;
  - <em>showGrades()</em>, which allows the student to see him/her grades,
  - <em>showGPA()</em>, which allows the student to see his/her GPA, etc..
- In addition, the Student Class despite of inheriting the attributes of the Person’s Class which are: <em>id, name, surname, username and password</em>, also has two other attributes, which are: <em>major</em> of string type, and <em>courses</em> of List <string> type.
</br></br>

<b>6. Courses (Class)</b>
- The Courses Class is one of the complementary classes in our system application.
- The function of this class is to the give the properties of each Course.
- The attributes of this class are: <em>id, courseName, credits and hours</em>, from which courseName is of data type string, and id, credits, and hours are of data type integer.
- The two methods, that Courses class contains are:
  - <em>readCourses()</em>, which reads all the courses that have been added by the Admin;
  - <em>ToString()</em>, which displays the attribute of this class.
</br></br>

<b>7. Grades (Class)</b>
- The Grades Class is the other complementary class in our system application.
- The attributes of this class are: <em>gradeId, courseId, studentId, score</em>, which are of type integer.
- While, the three methods that this class contains are:
  - <em>readGrades()</em>, which reads all the grades that have been added by the professor,
  - <em>readGradesForAStudent(int)</em>, which reads all the grades for a specific student,
  - <em>ToString()</em>, which displays gradeId, courseId, studentId, score.

#### Relationships
- With regards to relationships among these classes we have two <b><em>Generalization or Inheritance relationships</em></b>, which represent an “is-a” relationship between Professor and Person, and Student and Person, meaning that Professor subclass and Student subclass are specializations of the super class which is Person Class.
- Next, we have two <em><b>Dependency relationships</b></em> which are: Admin with Person, and Admin with Course, meaning that the Person depends on Admin and also Course depends on Admin. We have decided a Dependency relationship between these classes, because the changes to the definition of Admin will cause changes to the other classes (but not the other way around).
- In addition, we have three <em><b>Aggregation relationships</b></em> which represent a "part of" relationship, and these are: Professor with Courses, Professor with Grades, and Student with Courses. So, these relationships basically mean that Courses are part of Professor, Grades are part of Professor, and also Courses are part of Student. This relationship is represented by a solid line with an unfilled diamond at the association end connected to the class of composite.
- Finally, we have one <b><em>Composite relationship</em></b>, which represent a special type of aggregation where parts are destroyed when the whole is destroyed. This kind of relationship exists between Students and Grades, meaning that if we do not have the student’s class, we cannot have the Grades Class. This type of relationship is represented by a solid line with a filled diamond at the association connected to the class of composite.

### Use Case Diagrams
- The Use Case View of this Application, attached below encompasses the use cases that describe the behavior of our system as seen by its end users. So, basically each use case represents each of the functionalities that our application will offer from the user’s point of view.
<div align = "center">
  <img src="https://github.com/EndiTrico/Visual_Basic-University_Application/assets/85561383/c06d976c-3e88-43d6-9408-c688cdcc1058">
  <h4><em>Figure 3: Use Case Diagrams for SUNY Application</em></h4>
</div>


## Database Management System
- In our project, we have incorporated a database named Database_University, which is modeled in Microsoft Access. In the database, we stored various data that correspond to students professors, courses, and grades.

### Microsoft Access
- The database used in our assignment is Microsoft Access, and as the name says it was developed by Microsoft. Microsoft Access is a popular database management system that supports SQL (Structured Query Languages) and provides an SQL interface language for managing and querying databases.
- Access incorporates SQL as its standard database language, allowing users to perform a wide range of SQL operations on their Access databases. Microsoft Access supports, SQL queries, SQL data manipulation, SQL joins, SQL functions and expressions, and more.
- Also, Microsoft Access provides different advantages, some of which are listed below:
  <b>1. Easy Database Creation</b> → This means that Access provides a user-friendly interface that allows users to create databases without any programming knowledge.</br>
  <b>2. Relational Database Management</b> → Access supports the creation of relational databases which means the creation of relationships between tables, and these relationships come with efficient data organization and retrieval.</br>
  <b>3. Cost-Effective Solution</b> → Given that Microsoft Access is a component of the Office suite, businesses that currently use Office products can save money by using it. It reduces the demand for further database management software purchases, potentially saving money.</br>
</br>

### Structure of Database_University
- The Database_University consists of 6 important tables named Students, Professors, Courses, Grades, Students_Courses, and Professors_Courses.
- Each table has its own columns, and the primary key and detailed information for each table will be listed below:
  <b>1. Students Table</b> → Students Table consists of 6 columns named Student_ID of type auto number, First_Name of type long text, Last_Name of type long text, Username of type long text, Password of type long text, and Major of type long text. The primary key of this table is Student_ID, which uniquely defines each student with each other. Moreover, the username of the student must be unique.</br>
  <b>2. Professors Table</b> → Professors Table consists of 5 columns named Professor_ID, First_Name, Last_Name, Username, and Password. Except for the column Professor_ID, which is of type auto number, the other 4 columns are of type long text. The primary key of this table is Professor_ID which uniquely defines each professor with each other. Furthermore, the professor username is unique.</br>
  <b>3. Courses Table</b> → Courses Table consists of 4 columns, which are Course_ID, Course_Name, Credits, and Hours, in which the Course_ID is of type auto number, Course_Name is of type Long Text, while Credits and Hours are of type number. As we can see, the Column_ID represents the primary key of this table, while the Course_Name property is unique.</br>
  <b>4. Grades Table</b> → Grades Table is represented in 4 columns, which are named Grades_ID, Course_ID, Student_ID, and Grade_Score. The last 3 columns enter in the previous sentence are of type number, while the Grades_ID is of type auto number and it is the primary key of the table. Another property shown here is the usage of a foreign key, which is Course_ID which comes from the Courses Table, and Student_ID which comes from the Students Table.</br>
  <b>5. Students_Courses</b> → Students_Courses has only two columns, which are Student_ID,and Course_ID. This is a junction table to establish a many-to-many relationship between table Students, and Courses. Each of these columns is the foreign key of each table, Students and Courses. Only this table has a composite primary key (Student_ID & Course_ID).</br>
  <b>6. Professors_Courses</b> → Professors_Courses has also two columns that are named Professor_ID, and Course_ID. This table is a junction table to establish a many-to- many relationship between table Professors, and Courses. Moreover, each of these 2 columns represents the foreign key of the table Professors and Courses, and this table has a composite primary key (Professor_ID & Course_ID).</br>

### Database Relationships
- In our database, Database_University, we have created between the six tables various relationships.
- One type of relationship created in our database is a <b>one-to-many relationship</b>, which means that one record from the first table corresponds to zero or more records in the second table.Students and Grades have one-to-many relationships, in which one record from the Students Tablebelongs to zero or more records in the Grades Table. Another example of this relationship is between the Courses Table and Grades Table, and this means that one record from the Courses Table belongs to zero or more records to the Grades Table.
- The other type of relationship used in our case is the <b>many-to-many relationship</b> that occurs when multiple records from the first table correspond to multiple records from the second table and vice versa. To represent this type of relationship a junction table is used. This type of table acts as a bridge table that establishes a many-to-many relationship between two other tables, and it resolves the complexity of directly linking them. A junction table contains the primary key of the two tables that we are connecting. Students and Courses have many-to-many relationships and we created the Students_Courses junction table that contains the primary key of the Students Table, and Courses Table. Another example in our case is the Professors and Courses Table, which we resolved this conflict by creating the junction table named as Professors_Courses, which contains the primary key of both tables mentioned above.
- Below it is a representation of the ER Diagram
<div align = "center">
  <img src="https://github.com/EndiTrico/Visual_Basic-University_Application/assets/85561383/16d5be15-ecfc-4df8-b22c-06b0a242fa30">
  <h4><em>Figure 4: Entity Relantionship (ER) Diagram of Database_University</em></h4>
</div>
