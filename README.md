## DevDays2017 - Hands on Labs

### Pre Requisites

1. Install .NET Core SDK
Download and install .NET Core SDK  from the following link -[https://github.com/dotnet/core/blob/master/release-notes/rc4-download.md](https://github.com/dotnet/core/blob/master/release-notes/rc4-download.md)

2. Make sure that the version is  ```1.0.0-rc4-004771``` after installing the SDK by running the following command
     ```dotnet --version```
3. Execute any .NET Core CLI command such as ```dotnet new --help``` command to start one initializing the local package cache.

4. Install Visual Studio Code
[http://code.visualstudio.com/](http://code.visualstudio.com/)

### Create a test project
To make sure that everthing is working fine, create a test project and run it using the following commands

1. Create a new directory using from command line or GUI 
    ``` md Test```
    and set it as the current directory
    ```cd Test```
2. Create a console project 
    ``` dotnet new console```
    Output will be
    ```Content generation time: 58.5199 ms
    The template "Console Application" created successfully.``` 

3. Restore packages
   ``` dotnet restore```

4. Build and run the application
   ``` dotnet run```
5. If the you the below output when you execute the application in Step 4 then everything is fine and we are good to go
   ```Hello World!```