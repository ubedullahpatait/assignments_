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

**PreInit**
- Check the IsPostBack property to determine whether this is the first time the page is being processed.
- Create or re-create dynamic controls.
- Set a master page dynamically.
- Set the Theme property dynamically

**Init**
- This event fires after each control has been initialized.
- Each control's UniqueID is set and any skin settings have been applied.
- Use this event to read or initialize control properties.
- The "Init" event is fired first for the bottom-most control in the hierarchy, and then fired up the hierarchy until it is fired for the page itself.

**InitComplete**
- This event raised gets raised immidiately after page initialization..

**PreLoad**
- Happen just before the page load event

**Load**
- Page Load Event ,occur before the load event of all the individual control on that webform.

**Control Event**
- After the Page load event , the control event like buttons click, dropdownlist's selected index changed event are raised
- 
**LoadComplete**
- 
- Use this event for tasks that require that all other controls on the page be loaded.

**OnPreRender**
- Raised after the Page object has created all controls that are required in order to render the page, including child controls of composite controls.
- The PreRender event of individual controls occurs after the PreRender event of the page.
- Allows final changes to the page or its control.

**OnSaveStateComplete**
Raised after view state and control state have been saved for the page and for all controls.
Before this event occurs, ViewState has been saved for the page and for all controls.
Any changes to the page or controls at this point will be ignored.


**Render Method**
- This is a method of the page object and its controls (and not an event).
- The Render method generates the client-side HTML, Dynamic Hypertext Markup Language (DHTML), and script that are necessary to properly display a control at the browser.

**UnLoad**
- This event is used for cleanup code.
- At this point, all processing has occurred and it is safe to dispose of any remaining objects, including the Page object.
- Cleanup can be performed on:
- Instances of classes, in other words objects
- Closing opened files
- Closing database connections.
