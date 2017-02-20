
``` dotnet new web --framework netcoreapp1.1```

```dotnet restore```

```dotnet build```

```dotnet add package Microsoft.AspNetCore.Mvc```


```dotnet restore```

Add Controller
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

``` public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            

        }```

```
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
  app.UseMvc();
}
```

```dotnet build ```

```dotnet run```

Add route

```
app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

```

Add View

```<h1>Hello MVC from Core using View</h1>```

Modify action method

```
[HttpGet]      
public ActionResult Index() => View();
```

