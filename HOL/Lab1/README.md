## Creating a console application in .NET Core ##

 1. Open Command Prompt or Powershell
 
 2. Create a new directory using the below command  
 ```c:\md Lab1```
 
 3. Create a new console project in .NET Core in the newly created directory  
```c:\Lab1\dotnet new console```

     Output
     >Content generation time: 58.5199 ms  
     >The template "Console Application" created successfully.   

    This command will create two files in the current directory  
    #####Program.cs 
    ```csharp
	using System;
	namespace ConsoleApp  
	{ 
		 class Program  
	    {  
	        static void Main(string[] args)  
	        {
		        Console.WriteLine("Hello World!");  
	        }  
	    }  
	}  
    ```  

	#####csproj file
	```xml  
	<Project Sdk="Microsoft.NET.Sdk">
		
		<PropertyGroup>
		    <OutputType>Exe</OutputType>
		    <TargetFramework>netcoreapp1.0</TargetFramework>
		</PropertyGroup>

	</Project>
	```

    

 4. Restore the packages referred in the project   
 ```dotnet restore```

    > Restoring packages for C:\...\Lab1.csproj...  
    > Generating MSBuild file C:\...\Lab1.csproj.nuget.g.props.  
	> Generating MSBuild file C:\..\Lab1.csproj.nuget.g.targets.  
	> Writing lock file to disk. Path: C:\....j\Lab1.assets.json  
	> Restore completed in 1.7 sec for C:\...\Lab1.csproj.  
	>
	> NuGet Config files used:  
	>
	> C:\Users\....\AppData\Roaming\NuGet\NuGet.Config           
	> C:\Program Files (x86)\NuGet\Config\Microsoft.VisualStudio.Offline.config  

	> Feeds used:
	>
	> https://api.nuget.org/v3/index.json   
	> C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\  

 5. Build and Execute the project by running  
  ```dotnet run ```
   
   Output
   > Hello World!
