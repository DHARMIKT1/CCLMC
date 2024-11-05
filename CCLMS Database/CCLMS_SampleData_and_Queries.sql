-- SAMPLE DATA INSERTION FOR TESTING

-- Inserting librarian data
INSERT INTO librarian (librarianId, name, email, password, phoneNumber)
VALUES (1, 'librarian', 'librarian@gmail.com', 'password123', '1234567890');

-- Inserting student data
INSERT INTO student (studentId, name, email, password, phoneNumber, department, semester)
VALUES (1, 'student', 'student@gmail.com', 'password123', '9876543210', 'BCA', 5);

-- Inserting book data
INSERT INTO book (bookTitle, bookAuthor, bookPublication, ISBN, bookPrice, bookPage, bookQuantity, bookLanguage, bookCategory, bookPublishedYear, bookAvailableCopies)
VALUES 
('Windows Forms Programming in C#', 'Chris Sells', 'Addison Wesley', '9780321166599', 1200.00, 736, 10, 'English', 'Programming', 2003, 10),
('Beginning ASP.NET 4.5 in C#', 'Matthew MacDonald', 'Friendsof Apress', '9781430242512', 50.00, 900, 10, 'English', 'Programming', 2020, 10),
('SQL, PL/SQL – The Programming Language of Oracle', 'Ivan Bayross', 'BPB Publication', '9788183331671', 480.00, 443, 10, 'English', 'Database, Programming', 2010, 10),
('SQL Server Database Programming with C#: Desktop and Web Applications', 'Ying Bai', 'Auerbach Publications', '9780367338914', 5601.00, 642, 50, 'English', 'Database, Programming', 2023, 50);

-- Inserting feedback data
INSERT INTO feedback (StudentId, name, email, message)
VALUES (1, 'student', 'student@gmail.com', 'Great book!');

/**********************************************************************************************************************************************************/

-- SAMPLE QUERIES TO VIEW THE DATA

-- View admin data
SELECT * FROM librarian;

-- View student data
SELECT * FROM student;

-- View book data
SELECT * FROM addBook;

-- View issued book data
SELECT * FROM issueBook;

-- View returned book data
SELECT * FROM bookReturn;

-- View feedback data
SELECT * FROM feedbackStudents;

-- View reservation data
SELECT * FROM bookReservation;

-- View student reading history
SELECT * FROM studentReadingHistory;

-- View book fine data
SELECT * FROM bookFine;
