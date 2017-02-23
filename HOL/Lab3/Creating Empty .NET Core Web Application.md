#### Step 1

Create a new application using the templating engine targeting the netcoreapp1.1 framework. Use the --name option to specify the name for the project

```dotnet new  web --framework netcoreapp1.1 --name websample```    

When this command is executed it will create a project called WebSample under the current folder and the project files will be created inside it

If you list the contents of the directory, you will notice a new empty folder called **wwwroot** along with files there.

>Program.cs  
>Startup.cs  
>WebSample.csproj  
>[wwwroot]

Let's inspect the contents of the source files

##### Program.cs
```csharp
namespace WebSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
```

###### Startup.cs

```csharp
namespace WebSample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

```

####  Step 2    

Now, restore the packages using the following command

```dotnet restore ```  

#### Step 3

Let's build the project from the CLI

```dotnet build```

#### Step 4   

Start serving the application by directly calling the dll

```dotnet run WebSample.dll```  

###### Output

>Hosting environment: Production  
>Content root path: C:\MyWork\DevDays2017\HOL\Lab3\WebSample  
>Now listening on: http://localhost:5000  
>Application started. Press Ctrl+C to shut down.  

#### Step 4
If you take the url in the browser, you will see a **Hello World** message in the page. This message is coming from this line in the **startup.cs** file
```csharp
    app.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
```