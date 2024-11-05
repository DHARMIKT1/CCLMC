/* COLLEGE CAMPUS LIBRARY MANAGEMENT SYSTEM */ 

-- DATABASE NAME
CREATE DATABASE CCLMS;

USE CCLMS;

-- Librarian TABLE
-- This table stores information about the librarians.
CREATE TABLE librarian (
    librarianId BIGINT PRIMARY KEY NOT NULL,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    phoneNumber VARCHAR(15) NOT NULL UNIQUE
);

-- STUDENT TABLE
-- This table stores information about the students.
CREATE TABLE student (
    studentId BIGINT PRIMARY KEY NOT NULL,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL,
    phoneNumber VARCHAR(15) NOT NULL UNIQUE,
    department VARCHAR(30) NOT NULL,
    semester TINYINT NOT NULL
);

-- BOOK TABLE
-- This table stores information about the books in the library.
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

-- ISSUE BOOK TABLE
-- This table stores information about issued books.
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

-- RETURN BOOK TABLE
-- This table stores information about returned books.
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

-- FEEDBACK TABLE
-- This table stores feedback from students.
CREATE TABLE feedback (
    feedbackId INT PRIMARY KEY IDENTITY(1,1),
    studentId BIGINT NOT NULL,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    message NVARCHAR(MAX) NOT NULL,
    createdAt DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_feedback_studentId FOREIGN KEY (studentId) REFERENCES student(studentId)
);

-- BOOK RESERVATION TABLE
-- This table stores information about reserved books.
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

-- READING HISTORY TABLE 
-- This table stores the reading history of students.
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

-- FINE TABLE
-- This table stores information about fines imposed on late returns.
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

-- TRIGGER TO INSERT ISSUE HISTORY
-- Trigger to insert into StudentReadingHistory table after a book is issued.
CREATE TRIGGER trg_InsertBorrowHistory
ON issueBook
AFTER INSERT
AS
BEGIN
    INSERT INTO studentReadingHistory (studentId, bookId, issueBookDate)
    SELECT studentId, bookId, issueDate
    FROM inserted;
END;

-- TRIGGER TO UPDATE RETURN DATE IN HISTORY
-- Trigger to update returnBookDate in StudentReadingHistory table after a book is returned.
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

-- TRIGGER TO INSERT RESERVATION HISTORY
-- Trigger to insert into StudentReadingHistory table after a book is reserved.
CREATE TRIGGER trg_InsertReservationHistory
ON bookReservation
AFTER INSERT
AS
BEGIN
    INSERT INTO studentReadingHistory (studentId, bookId, reservationDate)
    SELECT studentId, bookId, reservationDate
    FROM inserted;
END;

-- TRIGGER TO UPDATE ISSUE DATE FROM RESERVATION
-- Trigger to update issueBookDate in StudentReadingHistory table from a reservation.
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

-- Create the CalculateFine function
-- This function calculates the fine amount based on dueDate and returnDate.
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

-- Create the CalculateFine trigger
-- This trigger inserts a fine entry into BookFine table after a book return if there is an overdue.
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
