# Dependency injection in Angular
Dependencies are services or objects that a class needs to perform its function. Dependency injection, or DI, is a design pattern in which a class requests dependencies from external sources rather than creating them.

Angular's DI framework provides dependencies to a class upon instantiation. Use Angular DI to increase flexibility and modularity in your applications.

**Creating an injectable service**
To generate a new HeroService class in the src/app/heroes folder use the following Angular CLI command.

```C#
ng generate service heroes/hero
```

```C#
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HeroService {
  constructor() { }
}
```

**Injecting services**
Injecting services results in making them visible to a component.

To inject a dependency in a component's constructor(), supply a constructor argument with the dependency type. The following example specifies the HeroService in the HeroListComponent constructor. The type of heroService is HeroService.

**sing services in other services**
When a service depends on another service, follow the same pattern as injecting into a component. In the following example HeroService depends on a Logger service to report its activities.

First, import the Logger service. Next, inject the Logger service in the HeroService constructor() by specifying private logger: Logger within the parentheses.

When you create a class whose constructor() has parameters, specify the type and metadata about those parameters so that Angular can inject the correct service.

Here, the constructor() specifies a type of Logger and stores the instance of Logger in a private field called logger.

The following code tabs feature the Logger service and two versions of HeroService. The first version of HeroService does not depend on the Logger service. The revised second version does depend on Logger service.

```C#
import { Injectable } from '@angular/core';
import { HEROES } from './mock-heroes';
import { Logger } from '../logger.service';

@Injectable({
  providedIn: 'root',
})
export class HeroService {

  constructor(private logger: Logger) {  }

  getHeroes() {
    this.logger.log('Getting heroes ...');
    return HEROES;
  }
}
```

