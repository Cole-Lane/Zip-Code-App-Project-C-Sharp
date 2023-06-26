# Zip Code App

GUI that allows the user to enter a 5 digit US zip code and then returns the city and state for that zip code.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)

## Features

**City and State Display:** The city and state are shown in easy to read text boxes after a valid zip code has been entered. Both of the text boxes are read only to prevent tampering but still allow the user to copy in case they want to google either.

**Error Handling:** Invalid or non-existent zip codes are handled by showing the user a simple pop-up window stating to enter a valid zip code. The text field is limited to 5 digits to prevent additional errors.

**Validation:** Makes use of HttpResponseMessage's IsSuccessStatusCode method to verify that Zippopotam.us was able to find a valid zip code.

**Feedback Messages:** User is instructed to check for letters or white space within the zip code text field if zippopotam.us returns anything other than a success code. 

**Clear Interface:** A simple interface that is easy to navigate and straightforward.

## Installation

<h3>Opening and using via <a href="https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2022">Microsoft Visual Studio</a> is preffered.</h3>

**This is targeted for a Windows desktop.**


Uses the following NuGets:

Newtonsoft.Json 

System.Net.Http


```bash
# How to run via Visual Studio
# Since this a forms project, I do not reccommend trying to build and run from the command line.
- Open Visual Studio.
- On the start window, select Clone a repository.
- Paste or type the repository location, and click the Clone button.
- Visual Studio will load the solution from the repository by using the Folder View in the Solution Explorer.
```

## Usage

Run / Start the application in Visual Studio and the GUI window will appear.
Just enter a 5 digit zip code and press enter to have the city and state load in the text boxes.

The main file runs an instance of the *ZipCodeApp* class
-This class has the listeners and is the file that makes a call to the *ZippoProcessor* class

The *ZippoProcessor* class makes use of the two NuGets, Newtonsoft.Json and System.Net.Http to handle the data returned from the *ApiHelper* class. This data is then matched to two seperate classes, *ZipModel* and *LocationInformation*, to handle the data format.

The *ApiHelper* class is a simple helper class that starts a new instance of HttpClient and sets the base address to insure that we are looking for US zip codes.


## Authors

List the authors or contributors of the project and provide links to their profiles or contact information.

## Resources

[Zippopotam.us](https://api.zippopotam.us/)

[Newtonsoft](https://www.newtonsoft.com/json/help/html/Introduction.htm)

[HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-7.0)

---
