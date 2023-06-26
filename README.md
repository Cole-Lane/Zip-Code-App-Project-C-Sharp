# Zip Code App

GUI that allows the user to enter a 5 digit US zip code and then returns the city and state for that zip code.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Run](#run)
- [Design](#design)

## Features

**City and State Display:** The city and state are shown in easy to read text boxes after a valid zip code has been entered. Both of the text boxes are read only to prevent tampering but still allow the user to copy in case they want to google either.

**Error Handling:** Invalid or non-existent zip codes are handled by showing the user a simple pop-up window stating to enter a valid zip code. The text field is limited to 5 digits to prevent additional errors.

**Validation:** Makes use of HttpResponseMessage's IsSuccessStatusCode method to verify that Zippopotam.us was able to find a valid zip code.

**Feedback Messages:** User is instructed to check for letters or white space within the zip code text field if zippopotam.us returns anything other than a success code. 

**Clear Interface:** A simple interface that is easy to navigate and straightforward.

## Installation

<h3>Opening and using via <a href="https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2022">Microsoft Visual Studio</a> is preferred.</h3>

**This is targeted for a Windows desktop.**


Uses the following NuGets:

Newtonsoft.Json 

System.Net.Http


```bash
# How to run via Visual Studio
# Since this a forms project, I do not recommend trying to build and run from the command line.
- Open Visual Studio.
- On the start window, select Clone a repository.
- Paste or type the repository location, and click the Clone button.
- Visual Studio will load the solution from the repository by using the Folder View in the Solution Explorer.
- Double-click on the Zip Code App Project.sln to navigate the project
```

## Run

Run / Start the application in Visual Studio and the GUI window will appear.
Just enter a 5 digit zip code and press enter to have the city and state load in the text boxes.

## Design

<h3>Program.cs</h3>
Runs an instance of the ZipCodeApp class

<h3>ZipCodeApp.Designer.cs</h3>
This is the front end design code for the GUI.

<h3>ZipCodeApp.cs</h3>

This class has the listeners for the buttons and text boxes in the GUI.

Helper functions to aid with removing text from the text boxes.

Makes a call to the ZippoProcessor class with the text from the zip code text box.


<h3>ZippoProcessor.cs</h3>

The ZippoProcessor class makes use of the two NuGets, Newtonsoft.Json and System.Net.Http to handle the data returned from the ApiHelper class. 

This data is then matched to two separate classes, ZipModel and LocationInformation, to handle the data format.

<h3>ApiHelper.cs</h3>
The ApiHelper class is a simple helper class that starts a new instance of HttpClient and sets the base address to ensure that we are looking for US zip codes.

<h3>ZipModel.cs</h3>

This class matches the first layer of data returned from the zippopotam.us API

Passes layer of info to the LocationInformation class

<h3>LocationInformation.cs</h3>
Matches string data returned from the zippopotam.us API for the "places" object. 

## Authors

Cole Lane

## Resources

[Zippopotam.us](https://api.zippopotam.us/)

[Newtonsoft](https://www.newtonsoft.com/json/help/html/Introduction.htm)

[HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-7.0)

---
