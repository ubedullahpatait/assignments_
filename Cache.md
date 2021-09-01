# Caching in asp.net
   - Caching is one of the most interesting concepts and operations in ASP.NET. If you can handle it,
    you can run any web application by applying the caching concept depending on the requirements.
- Caching is for providing solutions or the results to the users depending on their requested request, 
    admin needs to recreate the pages often depending on user requests…STOP!!!
    
**Types of caching**
- Page Caching
- Fragment Caching
- Data Caching

**Page Caching**
To cache an entire page's output we need to specify a directive at the top of our page, this directive is the @ OutputCache.

Here, in that statement Duration and VarByParam are the two attributes of the OutputCache directive

- Duration Attribute

This attributes represents the time in seconds of how long the output cache should be stored in memory. After the defined duration the content stored in the memory will be cleared automatically.

- VarByParam Attribute

This is the most important attributes; you can't afford to miss that in the OutputCache directory statement. It generally defines the query string parameters to vary the cache (in memory).

```C#
<%@ OutputCache Duration = 5 VaryByParam = "*"%>  

```
**Fragment caching**
In some scenarios we only need to cache only a segment of a page. For example a contact us page in a main page will be the same for all the users and for that there is no need to cache the entire page.

```C#
<%@ OutputCache Duration = 10 VaryByParam = "None" %>  
```

**Validation group**<br>
Validation groups allow you to validate data entry controls in groups. Server controls such as validation controls, Button and TextBox have ValidationGroup property that takes a string value. All the server controls having the same ValidationGroup value act as one validation group. 

```C#
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="validate" ControlToValidate="_usn" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
```

