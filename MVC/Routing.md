# Asp.net Routing

- Routing is a Pattern matching System
- Routing maps incoming request (from browser) to particular resource (controller & action method)

domain.com/Home/About<br>

**Route Table**
- we define route for action method
- all the routes are stored in route table
- Each Incoming request is mapped to this route table
- if URL match found then request goes to related controller action method
- if URL does not found then application returns 404 page.

**Default Route**
The default route table contain a single route (name default). The default route map the first segment  of URL to a controller name, the second  segment of URL to a
controller action, and third segment to parameter
```C#
 routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
```
**Route Constraint**
The Route constraint in Asp.net MVC Routing allows us to apply regular expression to url segment to restric whether the route will match the request.


**view Bag And View Data**
- Both view Bag and viewData are used to pass dta from controller to view

**View Bag**
- View Bag is a dynamic property
- This is used send data from controller to view
- we can assign any name to property


  
  **view Data**
  - ViewData work as a Dictionary
  - This  is also to send data to from controller to view
  - we can assign any name to key
```C#
namespace ViewBagAndViewData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MyCustomProperty = "Ubed";
            ViewBag.MyList = new List<string>() { "ubed", "kiran","appu" };
            return View();
        }

        public ActionResult Demo()
        {
            ViewData["Mykey"] = "This is Value for Any key";

            ViewData["MyList"] = new List<string>() { "ubed", "kiran", "appu" };
            return View();
        }


```
```C#
Index.cshtml
 <div>
        <h1>
           @ViewBag.MyCustomProperty
        </h1>
    </div>
    <div>
        <ul>
            @foreach (var item in ViewBag.MyList)
            {
                <li>@item</li>
            }
        </ul>
    </div>
```   
```C#

        <h1>@ViewData["Mykey"]</h1>

    </div>

    <div>
        <ul>
            @foreach (var item in (List<string>)ViewData["MyList"])
            {
                <li>@item</li>
            }
        </ul>
```
