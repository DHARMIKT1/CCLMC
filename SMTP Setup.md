# SMTP Gmail Setup Guide

To configure CCMLS application to send emails using Gmail's SMTP server, follow these steps:

## Step 1: Open the App Passwords Page

1. Open  https://myaccount.google.com/u/0/apppasswords in your web browser.

## Step 2: Sign in and Select Your Gmail Account

1. Sign in with your Google account credentials if prompted.
2. Select your Gmail account to proceed.

## Step 3: Generate an App-Specific Password

1. In the "App" dropdown menu, enter "CCLMS Project" as the app name.
2. Click on the "Generate" or "Create" button.
3. Copy the generated app-specific password shown. Save this password securely.

## Step 4: Configure SMTP Settings in `app.config`

Make sure to update the SMTP settings in CCLMS application's code with the following details:

1. Open the `app.config` (or `CCLMS.exe.config`) file in your project.
2. Locate the `<appSettings>` section and update it with the following details:

```xml
<appSettings>
    <!-- Email Configuration -->
    <add key="SenderEmail" value="your-email@gmail.com" />
    <add key="SenderPassword" value="your-app-specific-password" />
</appSettings>
```
Replace "your-email@gmail.com" with your Gmail email address and "your-app-specific-password" with the app-specific password generated in Step 3.

4. Save the app.config file after making changes.

## Step 5: Test Your SMTP Configuration
 
Ensure that the SMTP settings are correctly configured in your CCLMS application to send test emails and verify functionality.

