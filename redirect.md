# Redirect from one Page another page

Response.Redirect are used to transfer a user form One page to another web page.
- In this transfer is done by browser
- When we navigate Browser URL changes to redirected target page
- We can navigate any site or any page whether 
  They are present on same web server or different web server
  

Ex:
 public partial class WebForm1 : System.Web.UI.Page</br>
    {</br>
protected void Button1_Click(object sender, EventArgs e)</br>
 {</br>
    Response.Redirect("WebForm2.aspx");</br>
}</br>
}</br>

![responseredirect1](https://user-images.githubusercontent.com/67995958/131157294-4e6cd86e-b05b-4d78-86c3-1e903b8224b8.png)

if you want to intercept a click event in code use Button.In the button click event call Response.Redirect() method.
when the user click the button, the web server recieves, a request for redirection.The server then sends a response header
to the client. The client then automatically issues a  new GET request to the web server. The web server send the another
page to browser.

 **Server.Transfer**
 - Done by server
- Browser Url doesn't change
- when we need  to redirect between pages of
  the same server
  
  Ex:
  protected void Button1_Click(object sender, EventArgs e)</br>
 {</br>
    Server.Transfer("WebForm2.aspx");</br>
}</br>

![servertransfer](https://user-images.githubusercontent.com/67995958/131205979-30d364e2-6e85-400d-a5a0-521cd0bf2508.png)


