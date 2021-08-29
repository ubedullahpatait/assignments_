![asplifecycle](https://user-images.githubusercontent.com/67995958/131241021-f4a37166-0680-488d-ac96-4ac7fa4e3e8f.PNG)



| |  |
| ----------- | ----------------- |
| **Page request** |  When ASP.NET gets a page request, it decides whether to parse and compile the page, or there would be a cached version of the page; accordingly the response is sent. |
|**Starting of page life cycle**       | At this stage, the Request and Response objects are set. If the request is an old request or post back, the IsPostBack property of the page is set to true. The UICulture property of the page is also set.           |
|**Page initialization**      | At this stage, the controls on the page are assigned unique ID by setting the UniqueID property and the themes are applied. For a new request, postback data is loaded and the control properties are restored to the view-state values.  initialization of all page control --- textbox,checkbox etc.            |
|**Page load**       | At this stage, control properties are set using the view state and control state values.            |
| **Validation**       | Validate method of the validation control is called and on its successful execution, the IsValid property of the page is set to true.         |
| **Postback event handling**       |  If the request is a postback (old request), the related event handler is invoked.   event is triger when same page is loaded again            |
| **Page rendering**       |Before rendering, view state is saved for the page and all controls. During the rendering stage, the page calls the Render method for each control, providing a text writer that writes its output to the OutputStream object of the page's Response property.             |
| **Unload**       |At this stage the requested page has been fully rendered and is ready to terminate.at this stage all properties are unloaded and cleanup is performed.          |

