# **Steps followed in using directives :**

1. Create a **model** folder where list and item components folders also exists.

2. In **model** folder create .TS file and its name should be **model_name.model.ts**.

3. Use directives for the div which need to display.syntax : *ngFor="let model_name of Varible_name (declared in list.ts file)"

4. Replace the hard code using this syntax :  <testimonial-item (item selector name)[content]="model_name.contentMsg"  [img_src]="model_name.imageSource" [name]="model_name.name" [role]="model_name.role" ></testimonial-item>

5. **NOTE :** the model_name.contentMsg (should be in camel casing).

6. Import the below in list.component.ts

   - import {DataModel} from "../models/dataModel.model"
   - import { HttpClient } from '@angular/common/http'

7. The class of list.component.ts is given below.

   export class TestimonialListComponent implements OnInit{

   ​    dataModels : any;

   ​    //Lifecycle Hook

    ngOnInit(){

   ​    this.httpProxy.get( "http://localhost:5000/api/Testimonials(your postman url)").subscribe(data =>{

   ​        console.log(data);

   ​        this.dataModels=data;

   ​    } );

    }

    constructor(private httpProxy : HttpClient){

   ​    this.dataModels= null;

    }

   }

8. Import these in module.ts of list and item component.ts. and add those in declarations.

   - import {FormsModule} from "@angular/forms"
   - import { HttpClientModule } from '@angular/common/http'
   - import {CommonModule} from "@angular/common"

9. import this in app.module.ts and add to imports

   - import { HttpClientModule } from '@angular/common/http'

   ​

   ​

   ​

   ​