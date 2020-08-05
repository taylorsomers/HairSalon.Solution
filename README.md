# Hair Salon

  ### By Taylor Somers

## Description

  This program is a demonstration of one-to-many MySql database relationships created using C# and CSHTML in a .NET Core and MVC environment, and fully integrated with a MySQL schema. It's purpose is to create a user-friendly tracking system for a hair salon owner to organize the stylists they employ and keep track of the list of clients and which clients are associated with each stylists. Each stylist may be associated with many clients, but each client is associated with only one stylist, hence the one-to-many database relationship. While simple and not yet fully built out with all the possibly useful functionality, the essential features of C# and .NET development using databases are present and easily usable.


## Languages & Technologies Used:

  ### Programming Languages, Libraries, & Frameworks
  * CSHTML
  * CSS
  * C#
  * Entity Framework
  * MVC
  * MySQL
  * .NET Core
  * Razor

  ### Operating Systems & Programs
  * Brave
  * Microsoft PowerShell
  * Microsoft Windows 10
  * MySQL Workbench
  * Visual Studio Code

## Installation

  1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
  2.  Navigate to https://github.com/taylorsomers/HairSalon.Solution.
  3.  Click the green "Clone or download" button at the right of the screen.
  4.  Select "Download ZIP."
  5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
  6.  In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
  7.  Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
  8.  Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
  9.  Enter the command "dotnet build" in the terminal.
  10. Enter the command "dotnet run" in the terminal. The program should begin to run in the console.

  ### Database Setup Instructions

  DROP DATABASE IF EXISTS `Taylor_Somers`;
  CREATE DATABASE `Taylor_Somers`;

  USE `Taylor_Somers`;

  CREATE TABLE `clients` (
    `ClientId` int NOT NULL AUTO_INCREMENT,
    `StylistId` int DEFAULT NULL,
    `ClientName` varchar(255) DEFAULT NULL,
    `HairColor` int DEFAULT NULL,
    PRIMARY KEY (`ClientId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

  CREATE TABLE `stylists` (
    `StylistId` int NOT NULL AUTO_INCREMENT,
    `StylistName` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`StylistId`)
  ) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


## Specifications

  | Program Behavior | Example Behavior | Example Output | Met? (Y/N) |
  | ----------- | ----------- | ----------- | ----------- |
  | Program will display a splash page with the option to see the a list of stylists and a list of clients. | N/A | N/A | Y |
  | Program will display a Stylists/Index view with a list of all stylists who have been added into the system when the "List of Stylists" link is clicked. | "List of Stylists" > *Click* | "Stylists: Christine Gontarek, Dirk Funk, Lloyd Wabbit" | Y |
  | Program will display a Clients/Index view with a list of all clients who have been added into the system, as well as their associated stylists, when the "List of Clients" link is clicked. | "List of Clients" > *Click* | "Clients: Terence Maddock, Dirk Funk; Happy George, Christine Gontarek" | Y |
  | Program will display a Stylists/Details view with the stylist's name and a list of all clients assigned to that stylist when the associated link is clicked on the Stylists Index view. | "Christine Gontarek" > *Click* | "Stylist Details: Stylist Name: Christine Gontarek; Client: Happy George" | Y |
  | Program will display a Stylists/Create view with a form to add a new stylist when the associated link is clicked on the Stylists/Index view. | "Add New Stylist" > *Click* | "Add a New Stylist:
Stylist Name: [Input Field]; [Button: Add New Stylist]" | Y |
  | Program will return user to the Stylists/Index view with the new stylist's name appended to the list of stylists already entered into the system when the "Add New Stylist" button in the Stylists/Create view is clicked. | "Add a New Stylist: Stylist Name: [Clarence]; [Button: Add New Stylist]" > *Click* | "Stylists: Christine Gontarek, Clarence, Dirk Funk, Lloyd Wabbit" | Y |
  | Program will display a Clients/Create view with a form to input a new client's name and dropdown lists to select hair color and assigned stylist when the "Add New Client" link on the Stylists/Index or Stylists/Details view is clicked. | "Add New Client" > *Click* | "Add a New Client: Client Name: [Input Field]; Hair Color: [Dropdown List]; Stylist: [Dropdown List]; [Button: Add New Client]" | Y |
  | Program will display Clients/Index view with the newly added client and their associated stylist appended to the list when the new client entry form on the Clients/Create view is submitted. | "Add a New Client: Client Name: [Haggith Wigglesworth]; Hair Color: [Brown]; Stylist: [Dirk Funk]; [Button: Add New Client]" > *Click* | Client List: Terence Maddock, Dirk Funk; Happy George, Christine Gontarek; Haggith Wigglesworth, Dirk Funk" | Y |


## Stretch Goals
| Behavior | Input | Output | Met? (Y/N) |
| ----------- | ----------- | ----------- | ----------- |
| Program will allow user to assign specific hair treatments for clients using checkboxes. | "Color: *Check*; Curl: *Check*; Cut: *Check*" | "[Client Name], Preferred Treatment: Color, Curl, Cut" | N |


## Known Bugs

| Location : Message |  Situation  | Resolved (Y/N) |  Bug Resolution Strategy |
| ----------- | ----------- | ----------- | ----------- |
| .NETCoreApp,Version=v2.2.AssemblyAttributes.cs HairSalon\obj\Debug\netcoreapp2.2 : "Duplicate 'global::System.Runtime.Versioning.TargetFrameworkAttribute' attribute [HairSalon] csharp(CS0579) | Displayed when "dotnet build" and "dotnet watch run" commands are initiated. No apparent effect on program functionality. | Y | Add tag "<GenerateTargetFrameworkAttribute>false</GenerateTargetFrameworkAttribute>" to "<PropertyGroup>" within "<Project>" in HairSalon/HairSalon.csproj file. |
| Controllers\ClientsController.cs : "'Client' does not contain a definition for 'Stylist' and no accessible extension method 'Stylist' accepting a first argument of type 'Client' could be found (are you missing a using directive or an assembly reference?)" | Build error on cmd "dotnet build" | Y | Add "public virtual Stylist Stylist { get; set; }" to Client class in HairSalon/Models/Client.cs file. |
| Controllers\ClientsController.cs : "error CS1520: Method must have a return type" | Build error affecting display of "clients/index" view | Y | Correct public class "ClientsController", which had been misnamed 'HairSalonController'. |
| Models\Client.cs : "error CS0246: The type or namespace name 'Styling' could not be found (are you missing a using directive or an assembly reference?)" | Build error preventing loading of "clients/index" view | Y | Rename public "PreferredStyling Styling" property to public "Styling PreferredStyling" and rename public enum "PreferredStyling" to "Styling" in HairSalon/Models/Client.cs file. |
| Models\Stylist.cs : "error CS0246: The type or namespace name 'DisplayNameAttribute' could not be found (are you missing a using directive or an assembly reference?)" | Build error causing total failure of pages to render | Y | Add using directive "System.ComponentModel" to HairSalon/Models/Stylist.cs file. |
| Create.cshtml : "No overload for method 'CheckBoxFor' takes 3 arguments [HairSalon] csharp(CS1501)" | Problem affecting construction of new client form | Y | Add "[Flags]" to public enum "Styling" and add sequential power-of-two numerical values to options for public enum "Styling" in HairSalon/Models/Client.cs file. |
| Create.cshtml : "Argument 2: cannot convert from 'Microsoft.AspNetCore.Mvc.Rendering.SelectList' to 'bool?' [HairSalon] csharp(CS1503)" | Error in constructing text box for client preferred hair styling in new client form | Y | Eliminate all code relating to "PreferredStyling" property of "Client" class and all related UI code in views. |
| N/A : N/A | "Details" view for Stylists does not display the list of Clients associated with that Stylist. | Y | Add the following code "Stylist thisStylist = _db.Stylists .Include(stylist => stylist.Clients .FirstOrDefault(stylist => stylist.StylistId == id); return View(thisStylist)" to Details HTTPGet action in Stylist Controller. |


## Support & Contact Details

  * You are welcome to contact the author(s) via GitHub (taylorsomers) with any concerns, feedback, possible contributions, questions, or suggestions.


### Contributors

  * Taylor Somers


### License

  * This program is free to use under the GNU General Public License GPLv3. © 2020 Taylor Somers. All rights reserved.