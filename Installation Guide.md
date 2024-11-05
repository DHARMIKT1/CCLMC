# COLLEGE CAMPUS LIBRARY MANAGEMENT SYSTEM (CCLMS)

## Introduction

A College Campus Library Management System (CCLMS) is a software application designed to manage various library operations, including book reservations, tracking issued and returned books, managing fines, and collecting feedback from students.

## Prerequisites

Before you can run the CCLMS application, ensure you have the following installed:

- Visual Studio 2019 or later (Visual Studio 2022 Community recommended)
- .NET Framework 4.8 or later
- SQL Server Management Studio (SSMS) (SQL Server Management Studio 2019 Express recommended)
- Siticone.UI.WinForms.dll
- Noxius-UIBypass tool

## Step 1: Create the Database

1. Open the database folder.
2. Read the Readme file for detailed instructions on creating the database.

## Step 2: Set Up Siticone UI Framework

1. Open the Siticone UI Framework folder.
2. Read the Readme file for detailed instructions on setting up the framework.

## Step 3: Open the Project

Open the solution file (CCLMS.sln) in Visual Studio.

## Step 4: Configure the Connection String:

Ensure the CCLMS application is configured with the correct connection string to connect to the database.

1. Open the `app.config` (or `CCLMS.exe.config` for the executable) file in CCLMS project.
2. Locate the `<connectionStrings>` section and update the `CCLMS` connection string as follows:

```xml
	<connectionStrings>
		<!-- Connection string for the CCLMS database -->
		<!-- Replace your connection string -->
		<add name="CCLMS"
             connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=CCLMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
             providerName="System.Data.SqlClient" />
	</connectionStrings>
```
3. Save the app.config file after making changes.

## Step 5: Configure Email Settings for OTP and Fine Notifications

In the SendOtpForm class, SendPasswordForm class, and BookFine user control, make sure to update the senderEmail, senderPassword, smtpUsername, and smtpPassword with your email and password for sending OTP and fine notification emails.

#### Setting Up SMTP with Gmail

For detailed instructions on configuring SMTP to send emails via Gmail, please refer to the SMTP Setup Readme file located in the project directory. This file provides step-by-step guidance on setting up Gmail SMTP settings and generating an app-specific password.

## Step 6: Running the Application

1. Build the Solution:
In Visual Studio, build the solution by pressing Ctrl+Shift+B or by selecting Build > Build Solution from the menu.

2. Run the CCLMS Application:
Start the CCLMS application by pressing F5 or by selecting Debug > Start Debugging from the menu.

# Contact

For any questions or issues, please contact [my@gmail.com].
