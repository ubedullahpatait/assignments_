# DI LIFE TIME OPTIONS

**Transient**<br>
creates a new instance of the service, every time you request it.
```C#
services.AddTransient<ITransientService, SomeService>();
```

**Singleton**<br>
The Singleton scope creates a single instance of the service when the request for it comes for the first time. After that for every subsequent request, it will use the same instance. 
The new request does not create the new instance of the service but reuses the existing instance.
it ensure there is only one object availaible across the application in a controller state

```C#
services.AddSingleton<ISingletonService, SomeService>();
```

**Scoped**<br>
creates a new instance for every scope. (Each request is a Scope). Within the scope, it reuses the existing service.
The Services with scoped lifetime are created only once per each request (scope). I.e. It creates a new instance per request and reuses that instance within that request.

```C#
services.AddScoped<IScopedService, SomeService>();
```

