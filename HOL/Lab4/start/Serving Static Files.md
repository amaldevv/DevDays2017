##### Step 1

Create a new empty ASP.NET Core web application using the following command

```dotnet new web```  

##### Step 2

Add a new html file under the wwwwroot folder and save it as index.html

```html
<h1>Hello World from core</h1>
```

##### Step 3

Restore the dependencies

```dotnet restore```

##### Step 4

Build and run the web application using the below command

```dotnet run```

If you try to access the index.html page we created just now, will a page that has **Hello World** as content instead of the one which we gave in the html file . That's because eventhough we created the page, we didn't made the runtime aware of it.

##### Step 5

AspNetCore has a concept called   middlewares which are similar to the http handlers and modules we have in ASP.NET. .NET Core has got a middleware for serving the static files, you can add the package to your project using the below command  

```dotnet add  package Microsoft.AspNetCore.StaticFiles```

After adding this you need to add the below line in the ```configure``` method in the startup.cs file

```app.UseStaticFiles()```

This will make our content folder serverable. Let's run the application and will see if the file is properly served or not.  

```dotnet run```

##### Step 6
In this step we will see how make our newly created filed to be served as the default home page. Add the following line to your Configure method

```csharp
    app.UseDefaultFiles();
    app.UseStaticFiles();
```
Make sure that use specify ```app.UseDefaultFiles(); ``` before the ```app.UseStaticFiles(); ``` statement. By default it will search for the following files within the root folder and will serve the first file found 

>default.htm  
>default.html  
>index.htm  
>index.html 

So if the filename is different, then you can configure the options paramter as shown below in the Configure method

```csharp
    DefaultFilesOptions options = new DefaultFilesOptions();
    options.DefaultFileNames.Clear(); //clears the default list
    options.DefaultFileNames.Add("home.html"); //adds home.html as the first option in the list
    app.UseDefaultFiles(options); //pass options to the middleware
```


 