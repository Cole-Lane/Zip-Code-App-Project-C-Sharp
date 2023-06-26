# Zip Code App

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

GUI that allows the user to enter a 5 digit US zip code and then returns the city and state for that zip code.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Features

**City and State Display:** The city and state are shown in easy to read text boxes after a valid zip code has been entered. Both of the text boxes are read only to prevent tampering but still allow the user to copy in case they want to google either.

**Error Handling:** Invalid or non-existent zip codes are handled by showing the user a simple pop-up window stating to enter a valid zip code. The text field is limited to 5 digits to prevent additional errors.

**Validation:** Makes use of HttpResponseMessage's IsSuccessStatusCode method to verify that Zippopotam.us was able to find a valid zip code.

**Feedback Messages:** User is instructed to check for letters or white space within the zip code text field if zippopotam.us returns anything other than a success code. 

**Clear Interface:** A simple interface that is easy to navigate and straightforward.

## Installation

**This is targeted for a Windows desktop.**

Uses the following NuGets:

Newtonsoft.Json 

System.Net.Http

[Using Visual Studio](https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2022)

```bash
# Example installation steps
$ git clone https://github.com/Cole-Lane/Zip-Code-App-Project-C-Sharp.git
$ cd repository
$ npm install
```

## Usage

Explain how to use the project, providing examples or code snippets if applicable. This section should guide users through the main functionalities and demonstrate how they can interact with the project.

```bash
# Example usage
$ npm start
```

## License

This project is licensed under the [MIT License](LICENSE). 

## Authors

List the authors or contributors of the project and provide links to their profiles or contact information.

## Resources

[Zippopotam.us](https://api.zippopotam.us/)

[Newtonsoft](https://www.newtonsoft.com/json/help/html/Introduction.htm)

[HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-7.0)

---
