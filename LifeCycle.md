![asplifecycle](https://user-images.githubusercontent.com/67995958/131241021-f4a37166-0680-488d-ac96-4ac7fa4e3e8f.PNG)

- **Request of Page** : page is request from server<br/>
first time : compile and send the response<br/>
 not first time : check cache and send o/p
 
 - **start of page** : in this create Request and response object are created
 
 - **page initialization** : initialization of all page control --- textbox,checkbox etc.
 
 - **loading of page** : page is loaded with default values ex: we set textbox default value name
 
 - **validation** : all validation controls like require field validator range validator<br/>
check form validator if form value incorrect its display error if form value correct then data move forward

- **Handling of postback Event** : this event is triger when same page is loaded again
-rendering page : compilation of response in a way that user  can understand whatever response come from server <br/>
that user can understand.

- **unloading of page** : freeing up of memory

