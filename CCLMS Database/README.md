# College Campus Library Management System (CCLMS) Database

## Overview
This README provides instructions on how to set up the database for the College Campus Library Management System (CCLMS). The database is designed to store and manage information related to administrators, students, books, book issues, book returns, feedback, book reservations, reading history, and fines.

## Database Name
The database is named `CCLMS`.

## Prerequisites
- SQL Server Management Studio (SSMS). (SQL Server Management Studio 2019 Express recommended)

## Instructions

### Step 1: Create the Database

Run the following SQL command to create the `CCLMS` database:

```sql
CREATE DATABASE CCLMS;
```

### Step 2: Use the Database

Switch to the CCLMS database:

```sql
USE CCLMS;
```

### Step 3: Create the Tables 

#### librarian Table

Create the librarian table to store information about the librarians:

```sql
CREATE TABLE librarian (
    librarianId BIGINT PRIMARY KEY NOT NULL,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    phoneNumber VARCHAR(15) NOT NULL UNIQUE
);

```
#### Student Table

Create the student table to store information about the students:

```sql
CREATE TABLE student (
    studentId BIGINT PRIMARY KEY NOT NULL,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    phoneNumber VARCHAR(15) NOT NULL UNIQUE,
    department VARCHAR(30) NOT NULL,
    semester TINYINT NOT NULL
);
```

#### Book Table

Create the book table to store information about the books:

```sql
CREATE TABLE book (
    bookId BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    bookTitle NVARCHAR(MAX) NOT NULL, 
    bookAuthor VARCHAR(100) NOT NULL,
    bookPublication VARCHAR(255) NOT NULL, 
    ISBN VARCHAR(20) NULL,
    bookPrice DECIMAL(10,2) NOT NULL,
    bookPage BIGINT NOT NULL,
    bookQuantity INT NOT NULL, 
    bookLanguage VARCHAR(50) NOT NULL, 
    bookCategory VARCHAR(50) NOT NULL,
    bookPublishedYear INT NOT NULL DEFAULT 0,
    bookAvailableCopies INT NOT NULL
);
```

#### Issue Book Table

Create the issueBook table to store information about issued books:

```sql
CREATE TABLE issueBook (
    issueId INT PRIMARY KEY IDENTITY(1,1),
    bookId BIGINT NOT NULL,
    studentId BIGINT NOT NULL,
    issueDate DATETIME NOT NULL DEFAULT GETDATE(),
    dueDate DATE NOT NULL, 
    returnDate DATETIME NULL,
    status VARCHAR(20) NOT NULL DEFAULT 'Issued',
    CONSTRAINT FK_IssueBook_bookId FOREIGN KEY (bookId) REFERENCES book(bookId),
    CONSTRAINT FK_issueBook_studentId FOREIGN KEY (studentId) REFERENCES student(studentId)
);
```

#### Return Book Table

Create the bookReturn table to store information about returned books:

```sql
CREATE TABLE bookReturn (
    returnId INT PRIMARY KEY IDENTITY(1,1), 
    bookId BIGINT NOT NULL, 
    studentId BIGINT NOT NULL, 
    returnDate DATETIME NOT NULL DEFAULT GETDATE(), 
    dueDate DATE NOT NULL, 
    overdueFee DECIMAL(10, 2) DEFAULT 0.00, 
    CONSTRAINT FK_bookReturn_bookId FOREIGN KEY (bookId) REFERENCES book(bookId),
    CONSTRAINT FK_bookReturn_studentId FOREIGN KEY (studentId) REFERENCES student(studentId)
);
```

#### Feedback Table

Create the feedbackStudents table to store feedback from students:

```sql
CREATE TABLE feedback (
    feedbackId INT PRIMARY KEY IDENTITY(1,1),
    studentId BIGINT NOT NULL, 
    name VARCHAR(100) NOT NULL, 
    email VARCHAR(100) NOT NULL, 
    message NVARCHAR(MAX) NOT NULL, 
    createdAt DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT FK_feedback_studentId FOREIGN KEY (studentId) REFERENCES student(studentId)
);
```

### Book Reservation Table

Create the bookReservation table to store information about reserved books:

```sql
CREATE TABLE bookReservation (
    reservationId INT PRIMARY KEY IDENTITY(1,1), 
    studentId BIGINT NOT NULL, 
    bookId BIGINT NOT NULL, 
    reservationDate DATETIME NOT NULL DEFAULT GETDATE(), 
    expectedPickupDate DATE NULL, 
    reservationStatus NVARCHAR(20) NOT NULL DEFAULT 'Active', 
    CONSTRAINT FK_bookReservation_studentId FOREIGN KEY (studentId) REFERENCES student(studentId),
    CONSTRAINT FK_bookReservation_bookId FOREIGN KEY (bookId) REFERENCES book(bookId)
);
```

#### Student Reading History Table

Create the studentReadingHistory table to store the reading history of students:

```sql
CREATE TABLE studentReadingHistory (
    readingHistoryId INT PRIMARY KEY IDENTITY(1,1), 
    studentId BIGINT NOT NULL,
    bookId BIGINT NOT NULL, 
    reservationDate DATETIME NULL,
    issueBookDate DATETIME NULL,
    returnBookDate DATETIME NULL,
    CONSTRAINT FK_studentReadingHistory_studentId FOREIGN KEY (studentId) REFERENCES student(studentId),
    CONSTRAINT FK_studentReadingHistory_bookId FOREIGN KEY (bookId) REFERENCES book(bookId)
);
```

#### FINE BOOK TABLE

This table stores information about fines imposed on late returns.

```sql
CREATE TABLE bookFine (
    fineId INT PRIMARY KEY IDENTITY(1,1), 
    studentId BIGINT NOT NULL,
    bookId BIGINT NOT NULL,
    dueDate DATE NOT NULL, 
    returnDate DATE NOT NULL, 
    fineAmount DECIMAL(10,2) NOT NULL, 
    imposedDate DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT FK_bookFine_studentId FOREIGN KEY (studentId) REFERENCES student(studentId),
    CONSTRAINT FK_bookFine_bookId FOREIGN KEY (bookId) REFERENCES book(bookId)
);
```

### Step 4: Create Triggers For Reading History

#### Insert Issue History Trigger

Create a trigger to insert into the studentReadingHistory table after a book is issued:

```sql
CREATE TRIGGER trg_InsertBorrowHistory
ON issueBook
AFTER INSERT
AS
BEGIN
    INSERT INTO studentReadingHistory (studentId, bookId, issueBookDate)
    SELECT studentId, bookId, issueDate
    FROM inserted;
END;
```
#### Update Return Date in History Trigger

Create a trigger to update returnBookDate in the studentReadingHistory table after a book is returned:

```sql
CREATE TRIGGER trg_UpdateReturnHistory
ON bookReturn
AFTER INSERT
AS
BEGIN
    UPDATE studentReadingHistory
    SET returnBookDate = i.returnDate
    FROM studentReadingHistory srh
    INNER JOIN (
        SELECT r.studentId, r.bookId, r.returnDate
        FROM inserted r
    ) i ON srh.studentId = i.studentId AND srh.bookId = i.bookId AND srh.returnBookDate IS NULL;
END;
```

#### Insert Reservation History Trigger

Create a trigger to insert into the studentReadingHistory table after a book is reserved:

```sql
CREATE TRIGGER trg_InsertReservationHistory
ON bookReservation
AFTER INSERT
AS
BEGIN
    INSERT INTO studentReadingHistory (studentId, bookId, reservationDate)
    SELECT studentId, bookId, reservationDate
    FROM inserted;
END;
```

#### Update Issue Date from Reservation Trigger

Create a trigger to update issueBookDate in the studentReadingHistory table from a reservation:

```sql
CREATE TRIGGER trg_UpdateIssueHistoryFromReservation
ON issueBook
AFTER INSERT
AS
BEGIN
    UPDATE srh
    SET srh.issueBookDate = i.issueDate
    FROM studentReadingHistory srh
    INNER JOIN (
        SELECT ib.studentId, ib.bookId, ib.issueDate
        FROM inserted ib
        WHERE EXISTS (
            SELECT 1
            FROM bookReservation br
            WHERE br.studentId = ib.studentId
              AND br.bookId = ib.bookId
              AND br.reservationStatus = 'Active'
        )
    ) i ON srh.studentId = i.studentId AND srh.bookId = i.bookId AND srh.issueBookDate IS NULL;
END;
```
### Step 5: Create Functions and Triggers for Fines 

#### Calculate Fine Function

Create the CalculateFine function to calculate the fine amount based on dueDate and returnDate:

```sql
GO
CREATE FUNCTION dbo.CalculateFine (@dueDate DATE, @returnDate DATE)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @fine DECIMAL(10, 2);
    DECLARE @overdueDays INT;

    SET @overdueDays = DATEDIFF(DAY, @dueDate, @returnDate);
    
    IF @overdueDays > 0
        SET @fine = @overdueDays * 30.00;
    ELSE
        SET @fine = 0.00;

    RETURN @fine;
END;
GO
```

#### Create the Calculate Fine Trigger

Create a trigger to insert a fine entry into the bookFine table after a book return if there is an overdue:

```sql
GO
CREATE TRIGGER trg_CalculateFine
ON bookReturn
AFTER INSERT
AS
BEGIN
    INSERT INTO bookFine (studentId, bookId, dueDate, returnDate, fineAmount)
    SELECT 
        inserted.studentId,
        inserted.bookId,
        inserted.dueDate,
        inserted.returnDate,
        dbo.CalculateFine(inserted.dueDate, inserted.returnDate) AS fineAmount
    FROM 
        inserted
    WHERE 
        dbo.CalculateFine(inserted.dueDate, inserted.returnDate) > 0;
END;
GO
```
