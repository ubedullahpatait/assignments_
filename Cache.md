# Caching in asp.net
  - it is a technique of storing frequently used information in memory
  - when the same information is needed next time , it could be directively retrieved from the memory
  - it is important for data related transaction
  - retrive the data directively from cache rather then calling from every time in server machine.
  
    
**Types of caching**
- Page Caching
- Fragment Caching
- Data Caching

**Page Caching**
- basically will be able to store the complete page information and cache machine for particular duration.
- if within that duration any client make a request  and the data is not critically  important we avoid retrive that particular data every time  from the server


Here, in that statement Duration and VarByParam are the two attributes of the OutputCache directive

- Duration Attribute

This attributes represents the time in seconds of how long the output cache should be stored in memory. After the defined duration the content stored in the memory will be cleared automatically.

- VarByParam Attribute

This is the most important attributes; you can't afford to miss that in the OutputCache directory statement. It generally defines the query string parameters to vary the cache (in memory).

```C#
<%@ OutputCache Duration = 5 VaryByParam = "*"%>  

```
**Fragment caching**
- caching is required  to speed up the performance of the asp.net application here we will see how can retrive the single information from the cache 
 and how to store any data in the cache
 - whatever data whether its data set or any kind of information which you want to frequently you can simply store that in cache object and you can using 
  start whenever you want
```C#
<%@ OutputCache Duration = 10 VaryByParam = "None" %>  
```

**Validation group**<br>
Validation groups allow you to validate data entry controls in groups. Server controls such as validation controls, Button and TextBox have ValidationGroup property that takes a string value. All the server controls having the same ValidationGroup value act as one validation group. 

```C#
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="validate" ControlToValidate="_usn" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
```

