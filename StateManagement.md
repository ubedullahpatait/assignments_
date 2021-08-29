# State Management





**Client-Side State Management** <br/>
Whenever we use Client-Side State Management, the state related information will directly get stored on the client-side. 

**client side state management**
- View
- Hidden
- Cookies
- Control State
- Query Strings

**Server-Side State Management**
Server-Side State Management is different from Client-Side State Management but the operations and working is somewhat the same in functionality.
In Server-Side State Management all the information is stored in the user memory.

**Server-side Techniques**

- Session State
- Application State

**Client-Side State Management**

***View State***

- It is page-level State Management
- Used for holding data temporarily
- Can store any type of data
- Property dependent
- Http protocol is stateless protocol

```c#
 protected void Submit_Click(object sender, EventArgs e)
        {
            ViewState["Name"] = UserTextBox.Text;
            ViewState["Email"] = EmailTextBox.Text;

            UserTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;

            //Response.Redirect("ViewState2.aspx");
        }
        
        
        
         protected void Restore_Click(object sender, EventArgs e)
        {
            if (ViewState["Name"] != null)
            {
                UserTextBox.Text = ViewState["Name"].ToString();
            }

            if (ViewState["Email"] != null)
            {
                EmailTextBox.Text = ViewState["Email"].ToString();
            }
        }
    }
```
  **Cookies**
  
- Store information temporarily
- It's just a simple small sized text file
- Can be changed depending on requirements
- User Preferred
- Requires only a few bytes or KBs of space for creating cookies

**cookies brodly classified into two types**<br/>
- 1.Persistent Cookies**<br/>
- 2.Non persistent cookies**<br/>

**1. Persistent Cookies :** Remain on the client computer. even after the browser is closed.
                        you can configure how long the cookies remain using expire properties of the HttpCookies Object
 
**2.Non Persistent cookies :** if you dont set the expies property then cookies is called as non persistent cookie
                           non persistent cookie only remain in memory untill the browser is clos

```ruby
 public partial class Source : System.Web.UI.Page
    {
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = TextBox1.Text;
            cookie["Email"] = TextBox2.Text;
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);

            Response.Redirect("Destination.aspx");
        }
    }
}
 ``` 
 ```ruby
  public partial class Destination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                Label1.Text = cookie["Name"];
                Label2.Text = cookie["Email"];
            }
        }
    }
}
```
**Query Strings**<br/>
Query strings are used for some specific purpose. These in a general case are used for holding some value from a different page and move these values to the different page. The information stored in it can be easily navigated to one page to another or to the same page as well.

```c#
 public partial class Login : System.Web.UI.Page
    {
  protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Display.aspx?Name=" + TextBox1.Text + "&Email=" + TextBox2.Text );
        }
 }
 ```
 ```c#
  public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["Name"];
            Label2.Text = Request.QueryString["Email"];
        }
    }
```

**Server-side Techniques**

**SessionState**<br/>
 session helps to maintain the user state and data all over the application by storing the information on the server memory. Also a session can store any kind of information or object on the server side and is accessible in the entire website.

```C#
 protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["Email"] = TextBox2.Text;

            Response.Redirect("WebForm2.aspx");
        }
```       
```c#
 protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                Label1.Text = Session["Name"].ToString();
            }

            if (Session["Email"] != null)
            {
                Label2.Text = Session["Email"].ToString();
            }
```    

**Application State**<br/>
Application State is a state management technique. Application State is stored in the memory of the the server and is faster than storing and retrieving information in a database. Session sate is specific for a single user session, but Application State is for all users and sessions. Application State does not have a default expiration period. When we close the worker process the application object will be lost. Technically the data is shared amongst users by a HTTPApplcationState class and the data can be stored here in a key/value pair. It can also be accessed using the application property of the HTTPContext class.

```c#
 protected void Button1_Click(object sender, EventArgs e)
        {
            Application["Name"] = TextBox1.Text;
            Application["Email"] = TextBox2.Text;

            Response.Redirect("WebPage2.aspx");
        }
 ```
 ```C#
  public partial class WebPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Application["Name"].ToString();
            Label2.Text = Application["Email"].ToString();
        }
    }
```    
    
    
        


 
    
