# Validator Control
- RequiredFieldValidation Control
- CompareValidator Control
- RangeValidator Control
- RegularExpressionValidator Control
- CustomValidator Control
- ValidationSummary


**RequiredFieldValidation Control**
- required field validator when we want to make some particular textbox mandatory then we will use the required field
```C#
 <tr>
 <td class="auto-style3">
 <asp:Label ID="Label1" runat="server" Text="User Id"></asp:Label>
  </td>
 <td class="auto-style4">
   <asp:TextBox ID="txtUserID0" runat="server" ></asp:TextBox>
    &nbsp;
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserID0" Display="Dynamic" 
   ErrorMessage="Require user id" ForeColor="Red" SetFocusOnError="True">Invalid user Id</asp:RequiredFieldValidator>
     </td>
       </tr>
```
**CompareValidator Control**
- compare validator when we want to compare two value
```C#
<tr>
<td class="auto-style2">
 <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
    </td>
  <td>
  <asp:TextBox ID="txtcpwd" runat="server" ></asp:TextBox>
   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtcpwd" Display="Dynamic" 
  ErrorMessage="Password Mismatch" SetFocusOnError="True" ControlToCompare="txtpwd" ForeColor="Red"></asp:CompareValidator>
      </td>
   </tr>
```        

**RangeValidator Control**
- when we want to check specific data like number of amout  or date in particular range at that time we use Range validator
```C#
<tr>
 <td class="auto-style2">
   <asp:Label ID="Label7" runat="server" Text="DOB"></asp:Label>
 </td>
  <td>
  <asp:TextBox ID="txtdob" runat="server" ></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtdob" Display="Dynamic" 
  ErrorMessage="Age must be between the 18 to 45" ForeColor="Red" SetFocusOnError="True" Type="Date"></asp:RangeValidator>
    </td>
   </tr>
```
```C#
 protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidator1.MinimumValue = DateTime.Now.AddYears(-45).ToShortDateString();
            RangeValidator1.MaximumValue= DateTime.Now.AddYears(-18).ToShortDateString();
        }
```

**RegularExpressionValidator Control**
- expression evaluator will be used when we want value in particular format foe ex: email id must be in particular format or @ then some
  domain name (.) at least one that is an expression use this validator using regular expression control
```C#
<tr>
   <td class="auto-style2">
   <asp:Label ID="Label5" runat="server" Text="Mobile Number"></asp:Label>
</td>
 <td>
 <asp:TextBox ID="txtmob" runat="server" ></asp:TextBox>
 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtmob" Display="Dynamic" 
 ErrorMessage="Invalid mob number" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
    </td>
            </tr>
```   
**CustomValidator Control**
- where we can define our own concept like what i want to validate at that time we use customvalidator control
```C#
<tr>
<td class="auto-style3">
     <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
  </td>
  <td class="auto-style4">
       <asp:TextBox ID="txtpwd" runat="server" ></asp:TextBox>
 <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtpwd" Display="Dynamic" 
   ErrorMessage="Invalid Password" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
    </td>
     </tr>
 ```    
 ```C#
 protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int len = args.Value.Length;
            if (len >= 8 && len <= 15)

                args.IsValid = true;
            else
                args.IsValid = false;
        }
```
