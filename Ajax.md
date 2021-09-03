**AJAX**
AJAX stand for Asynchronous Javascript and XML

- Ajax is new technique for creating  better faster and more interactive web application with the help of XML, HTML CSS and Javascript

- update web page without reloading the page
- Request data from server -after the page has reloaded
- Recieve data from server-after the page has loaded

**Script Manager**
The ScripManager Control manages the partial page updates for UpdatPanel controls that are on the ASP.NET web page or inside a user control on the web page. This control manages the client script for AJAX-enabled ASP.NET web page and ScripManager control support the feature as partial-page rendering and web-service calls.

**Update Panel Control**
You can refresh the selected part of the web page by using UpdatePanel control, Ajax updatepanel control contains a two child tags that is ContentTemplate and Triggers. In a ContenTemplate tag we used to place the user controls and the Trigger tag allows you to define certain triggers which will make the panel update its content.

```C#
 <div>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="Sum  of two number using AJAX"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <table align="left" class="auto-style5">
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="First Number"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label3" runat="server" Text="Second Number"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
                                <br />
                                <br />
                                <asp:Label ID="Label4" runat="server" CssClass="auto-style13" Font-Bold="True" ForeColor="Red"></asp:Label>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
```
**AsyncPostBackTrigger**

Defines a control and optional event of the control as an asynchronous postback control trigger that causes an UpdatePanel control to refresh.
```C#
  <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button2" EventName="click" />
                </Triggers>
                
````
**UpdateMode**
When an UpdatePanel control is not inside another UpdatePanel control, the panel is updated as determined by the settings of the UpdateMode and ChildrenAsTriggers properties, together with the collection of triggers

```C#
<asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="Label3" runat="server"></asp:Label><br />
                      <asp:Button ID="Button3" runat="server" Text="submit" OnClick="Button1_Click" />
                </ContentTemplate>
            </asp:UpdatePanel><br />
            
            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                  <ContentTemplate>
                    <asp:Label ID="Label4" runat="server"></asp:Label><br />
                      <asp:Button ID="Button4" runat="server" Text="submit" OnClick="Button1_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
```
