# EMAIL SENDER PROGRAM TEST

## TASK 1 - Shortcommings before refactoring
### *After reviewing the given code, I have identified several shortcomings that need to be addressed to make the code more readable, understandable and robust. Here are the shortcomings that I have identified:*

- The program lacks proper comments and documentation. Although some of the methods and variables are self-explanatory, there are some that are not easy to understand. Therefore, the code should be documented and commented in a clear and concise manner, so that it is easy for others to understand and modify the code.
- The variable names are not descriptive enough. In some cases, the variable names are too short and do not provide any indication of what the variable represents. Therefore, the variable names should be made more descriptive, so that it is clear what they represent.
- There is a mix of debugging code and production code, which can cause confusion and errors. Therefore, the debugging code should be separated from the production code, so that it is clear which code is being executed in which environment.
- The code is not modularized. This can make the code difficult to maintain and modify. Therefore, the code should be modularized into smaller, more manageable units.
- The error handling is not robust. The code simply returns a Boolean value indicating success or failure, but it does not provide any information about the error. Therefore, the error handling should be improved to provide more detailed information about the error.

### To address these shortcomings, I took the following steps:
- Added only neccessary comments and documentation to the code. This will make it easier for others to understand and modify the code.
- Renamed the variables to made them more descriptive. This will make it easier to understand what each variable represents.
- Separated the debugging code from the production code. This will reduce confusion and errors.
- Modularized the code into smaller, more manageable units. This will make the code easier to maintain
- I also followed C# conventions: I used C# conventions to write the code such as using PascalCasing for function and constants names, using CamelCasing for variable names and using braces for single line if statements.
- Finally I used SOLID principles as guiding principle to write easy to ready and maintain code.

## TASK 2: Design and Architecture
### I will create a architecture design for the project stating the data, logics, and dependencies for the project.
### I would use *MVC* (Model View Controller) architecture.
- I would put all data relations in their seperate classes under a folder structure called *models"
- All logics will go into services folder in their respective modular classes and they will a dependency for other logics that will use them.
- Since this is a console app, my view would be the Program.cs file and I will structure it to be very modular.
### I will have guides for writing my code
- I will follow SOLID principles in writing my classes so that I can easily debug or extend them
- I will also use C# code conventions so my code will be readable to everyone
### I will use dependency injection so that I can easily test my code


## :man_technologist: Author
Emmanuel Aweperi Adiba 
- [Github Profile]( https://github.com/AdibaEmma)
- Contact: +233556137400