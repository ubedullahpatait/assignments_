# Binding in Angular
Property binding in Angular helps you set values for properties of HTML elements or directives. Use property binding to do things such as toggle button functionality, set paths programmatically, and share values between components.

**types of data binding in angular**
- Interpolation.
- Property binding.
- Class binding.
- Style binding.
- Event binding.
- Two-way binding.<br>

**Interpolation**
- Text interpolation lets you incorporate dynamic string values into your HTML templates. Use interpolation to dynamically change what appears in an application view, such as displaying a custom greeting that includes the user's name.<br>
- Interpolation refers to embedding expressions into marked up text. By default, interpolation uses the double curly braces {{ and }} as delimiters.<br>
```C#
currentCustomer = 'Maria';
<h3>Current customer: {{ currentCustomer }}</h3>
```
**Property binding**<br>
To bind to an element's property, enclose it in square brackets, [], which identifies the property as a target property. A target property is the DOM property to which you want to assign a value. For example, the target property in the following code is the image element's src property.
```C#
<img [src]="itemImageUrl">
```

**Event Binding**<br>
- Event binding lets you listen for and respond to user actions such as keystrokes, mouse movements, clicks, and touches.
- To bind to an event you use the Angular event binding syntax. This syntax consists of a target event name within parentheses to the left of an equal sign, and a quoted template statement to the right. In the following example, the target event name is click and the template statement is onSave().
```C#
<button (click)="onSave()">Save</button>
```
