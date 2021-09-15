# Html Helper

1 Inline HTML helpers <br><br>
2 Built-In HTML helpers <br>
- Standard HTML helpers
- Strongly Typed HTML helpers
- Template HTML helpers

3 Custom HTML helpers

**Inline HTML helpers**
- These are created on single View and are used on same page
- Inline helper can be created using @helper tag
```C#
 @helper HelperName(parameter)
 {
   //code
 }

@HelperName(parameters)
```
Example
```C#
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        @helper MyListHelper(string[] str)
        {
            if (str.Length == 0)
            {
                <label>No data Exist</label>
            }
            else
            {
                <ul>
                    @foreach (var item in str)
                    {
                        <li>
                            @item
                        </li>
                    }
                </ul>
            }
        }

    </div>
    <label>Example 1 - Name list</label>
    <div>
        @MyListHelper(new string[] { "Tom", "Harry", "John", "Mark" })
    </div>

    <div>
        <label>Example 2 - programming Language </label>
        <div>
            @MyListHelper(new string[] { "C#", "java", "php", "C" })
        </div>
    </div>


    <div>
        <label>Example 3 - Empty List </label>
       
        <div>
            @MyListHelper(new string[] { })
        </div>
    </div>
</body>
</html>
```

**Standard HTML helper**

- @Html.ActionLink() - Used to create link on html page
- @Html.TextBox() - use to create text
- @Html.CheckBox() - used to create checkbox
- @Html.RadioButton() - used to create radio button
- @Html.BeginForm() - used to start from
- @Html.EndForm() - used to end a form
- @Html.DropDownList() - use to create dropdown list
- @Html.Hidden() - Used to create Hidden Field

```C#
<body>
    <div>
        @Html.ActionLink("click me", "About")
    </div>
    <br />
    @{
        string name = "ubed";
    }
    @Html.TextBox("txtBox1", name, new { id = "custmid", @class = "custmclass", style = "width:200px" })

    <br />
    <br />
    @Html.CheckBox("checkBox1", true)

    <br />
    <br />
    @Html.Password("Password", "", new { @class = "form-control" })
    <br />
    <br />
    @Html.RadioButton("Gender", "Male", true, new { id = "male" }) Male
    @Html.RadioButton("Gender", "Female", false, new { id = "female" }) Female
    <br />
    <br />
    @{
        List<string> strList = new List<string> { "BCA", "BCS", "MCA", "MCS" };
    }
    @Html.DropDownList("ddlCourse", new SelectList(strList, strList.FirstOrDefault()), "--Select Course----")
    <br />
    <br />
      <div> @Html.Label("User Name ") </div>
      <br/>
      <br/>
      @using (Html.BeginForm("Index", "Home", FormMethod.Post))  
  
{  
// Code here..  
} 
   ```   
      
