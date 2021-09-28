# Binding in Angular
Data binding is a technique, where the data stays in sync between the component and the view. Whenever the user updates the data in the view, Angular updates the component. When the component gets new data, the Angular updates the view.

**types of data binding in angular**
- Interpolation.
- Property binding.
- Class binding.
- Style binding.
- Event binding.
- Two-way binding.<br>

**Interpolation**
- Interpolation allows us to include expressions as part of any string literal, which we use in our HTML. The angular evaluates the expressions into a string and replaces it in the original string and updates the view. You can use interpolation wherever you use a string literal in the view.<br>
- Interpolation refers to embedding expressions into marked up text. By default, interpolation uses the double curly braces {{ and }} as delimiters.<br>
```C#
 dyName:string = "ubed";
<p>
    My Name is {{dyName}}
</p>

```
**Property binding**<br>
To bind to an element's property, enclose it in square brackets, [], which identifies the property as a target property. A target property is the DOM property to which you want to assign a value.
```C#
<input type="text" name="" id="" [value]="dyName">
<br><br>
```

**Event Binding**<br>
- Event binding lets you listen for and respond to user actions such as keystrokes, mouse movements, clicks, and touches.
- To bind to an event you use the Angular event binding syntax. This syntax consists of a target event name within parentheses to the left of an equal sign, and a quoted template statement to the right. 
```C#
msg:string =""
    onAddcart()
    {
        this.msg="product added in cart"

    }

<button (click)="onAddcart()">Addcart</button>

<p>{{msg}}</p>
```

**Two way binding**<br>
Two-way data binding refers to sharing data between a component class and its template. If you change data in one place, it will automatically reflate at the other end.
```C#
<input type="text" value="ubed" [(ngModel)]="uname">
<p>{{uname}}</p>
```

**Class Style binding**<br>
The Angular Class binding is used to add or remove classes to and from the HTML elements. You can add CSS Classes conditionally to an element, hence creating a dynamically styled element.
```C#
component
 myStyle1:string = "50px"
   
    mltclasses ={
        class1: true,
        class2:false,
        class3:true
    }

    mltStyle ={
        "background": "red",
        "border" : "10px solid green"
    }
    
    html
    
    <div class="box" [ngClass]="mltclasses">class binding</div>
<br><br>
<div class="box" [ngStyle]="mltStyle">class binding</div>
```    
    
    
