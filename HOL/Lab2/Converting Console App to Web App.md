
#### Step 1
Create a new console application with target framework as ```netcoreapp1.1```
```sh
dotnet new console --framework netcoreapp1.1
```
This command will create two files, one contains source code and other has project details

##### Program.cs

```charp  
using System;

namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

```  

##### csproj file

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp1.1</TargetFramework>
  </PropertyGroup>

</Project>

```
Here you can see that we have now ```netcoreapp1.1``` as default target framework instead of ```netcoreapp1.1```

#####Step 2

Let's add the nuget package for Kestrel Server

```sh
dotnet add package Microsoft.AspNetCore.Server.Kestrel
```
If you check the csproj file now, you will see the reference for the package in it.
```xml
<PackageReference Include="Microsoft.AspNetCore.Server.Kestrel">
      <Version>1.1.0</Version>
</PackageReference>
```

#### Step 3 

Now modify the code in the ```Program.cs``` file to import ASP.NET Core namespaces

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
```

#### Step 4 

Restore the dependencies using the below command

```sh
dotnet restore
```

#### Step 5

Execute the project using the below command to host it in Kestrel Server.

```sh
dotnet run
```

###### Output

>Hosting environment: Production  
>Content root path: C:\\...\Lab2\finish\bin\Debug\netcoreapp1.0  
>Now listening on: http://localhost:5000  
>Application started. Press Ctrl+C to shut down.  


