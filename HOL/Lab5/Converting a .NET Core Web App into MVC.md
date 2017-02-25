##### Step 1

Create a new empty web application targeting netcoreapp1.1 framework using the below statement

``` dotnet new web --framework netcoreapp1.1```

##### Step 2

Restore the dependencies

```dotnet restore```

##### Step 3

Build the application using ```dotnet build``` command

##### Step 4

To convert it to an MVC application, add the following NuGet package to your project using the statement given below

```dotnet add package Microsoft.AspNetCore.Mvc```

After adding it, execute ```dotnet restore``` command to restore the dependencies for the package we just added

##### Step 5
Create a folder named Controller in the root directory and create file named HomeController.cs. Then, add a new get method inside which will return a string as shown below.  

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet]      
      public string Index() => "Hello MVC from Core";
    }

}
```
##### Step 6
If you try to call this action from the browser now, you won't see the desired output. That's because the runtime is not instructed to serve MVC.

For that you need to call the ```AddMvc()``` method in the ```ConfigureServices``` method in ```Program.cs``` file as shown below 

```csharp
public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            

        }```

```
After that in the ```Configure``` method in the same file, call the ```UseMvc()``` method   

```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
  app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
}
```
Let's build and run the application using the following commands to see if the action method is getting executed   

```dotnet build ```

```dotnet run```


##### Step 7

Let's see now how we can add view for our MVC application. Add new folder called Views in the root directory and then create a sub folder named Home inside it. After that create an ```cshtml``` page with the following contents and save it as ```Index.cshtml```

```<h1>Hello MVC from Core using View</h1>```

Let's now change the action method to serve the contents of the view instead of the string

```
[HttpGet]      
public ActionResult Index() => View();
```

Build and run the application using ```dotnet run```

