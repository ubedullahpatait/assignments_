# ASP.NET Core - Exception Handling

ASP.NET Core includes a middleware that makes exception handling

To handle exceptions and display user friendly messages, we need to install Microsoft.AspNetCore.Diagnostics NuGet package and add middleware in the Configure() method

The Microsoft.AspNetCore.Diagnostics package includes following extension methods to handle exceptions in different scenario:

- UseDeveloperExceptionPage
- UseExceptionHandler

**UseDeveloperExceptionPage**<br>
The UseDeveloperExceptionPage extension method adds middleware into the request pipeline which displays developer friendly exception detail page. This helps developers in tracing errors that occur during development phase.

As this middleware displays sensitive information, it is advisable to add it only in development environment.

```C#
public class Startup
{
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment() || env.IsStaging())
        {
            app.UseDeveloperExceptionPage();
        }

        app.Run(context => { throw new Exception("error"); });
    }
}
```

**UseExceptionHandler**<br>
In MVC Core application, we might want some other controller to handle all exceptions and display custom user friendly error messages. The UseExceptionHandler extension method allows us to configure custom error handling route. This is useful when an application runs under production environment.
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{

    if (env.IsDevelopment() || env.IsStaging())
    {
        app.UseDeveloperExceptionPage();
    }
    else 
    {
        app.UseExceptionHandler("/Home/Error");
    }

    //code removed for clarity 
}
```
