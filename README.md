# &#x1F4CB; **Factory Maintenance System** &#x1F4CB;

#### **By Casey Hill**

#### A Factory Maintenance System in the form of a web application that allows the a Manager to add both Machines and Engineers to an internal database. &#x1F50C; &#x1F477; &#x1F527;

#### ...._"A stitch in time saves nine."_ - Proverb

## **Technologies Used**

-   C#
-   .NET 6.0.402
-   Entity Framework Core version 6.0
-   EFCore Migration
-   EFCore Design
-   dontnet CLI
-   MSBuild
-   VS Code
-   MySql Server
-   MySQL Workbench
-   SQL
-   git
-   GitHub

## **Description**

Welcome to the Factory Maintenance System!

This Factory Maintenance System helps manages organize Engineer and Machine information to help keep operations running smoothly. Add new Engineers and Machines and assign Engineers to Machines and vice versa to keep organized and keep scheduling maintenance in check.

Use the links at the bottom of the page to navigate to different pages pages.

## **Setup/Installation Requirements** &#x1F4BB;

<details>
<summary> Initial Setup </summary>

-   Clone this repository to your local machine.
    -   `$ git clone https://github.com/0art-vandelay0/Factory.git`
-   Open VS Code (or your IDE of choice).
-   Open the top level directory you just cloned.
</details>

<details>
<summary> Database Setup </summary>

-   Use a MySql RDBMS like MySql Workbench to import/upload the `casey_hill.sql` file and create your database.
-   In your Factory Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

    {<br>
    &emsp;&emsp;"ConnectionStrings": {<br>
    &emsp;&emsp;&emsp;&emsp;"DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[USERNAME-GOES-HERE];pwd=[PASSWORD-GOES-HERE];" }<br>
    }<br>

-   Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
</details>

<details>
<summary> Finish Setup </summary>

-   In your terminal:

        -   Change directory (cd) to Factory.
        -   Enter `dotnet build` into your terminal.
        -   Enter `dotnet run` (or `dontnet watch run` to see edits in real time).

-   A web page will automatically open in your browser
-   Use the navigation at the bottom of the page to view Engineers or Machines (both will be empty to start)
-   Follow the links based on what every your needs are.
</details>
That's it!

#### Debugging

If the program does not run, try the following:

-   Check that you have the appropriate packages installed to run dotnet
    -   In your Terminal, enter the following commands:<br>
        `$ dotnet tool install --global dotnet-ef --version 6.0.0`<br>
        `$ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`<br>
        `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0`
-   Try creating a `global.json` file in the Factory dir that contains the following code to override the default version, if your version exceeds .NET 6.0:<br>
    {<br>
    &emsp;&emsp; "sdk": {<br>
    &emsp;&emsp;&emsp;&emsp;"version": "6.0.402"<br>
    &emsp;&emsp;}<br>
    }

## **Known Bugs**

-   There is currently neither a Delete nor Edit/Update functionality from within the program.
    To delete or edit, use you RDBMS Software or Querey MySql Server at the command line with your existing local setup.

## License

Please contact [caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=You%20are%20amazing...) with any the following:

-   Found bugs &#x1F41E;
-   Alterations and improvements
-   General Questions
-   Any contributions you would like to make! &#x1F5DD;

Copyright (c) 06/16/2023 Casey Hill
