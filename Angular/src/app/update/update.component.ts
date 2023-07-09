import { Component } from '@angular/core';
import { ApiService } from '../service/api.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent {
  carlist:any={carId:0, carName :'', carType :'',  price : '', availability :''}
  
  constructor(private api: ApiService, private router: Router) {
    
  }
  
 
  
  public UpdateCarById(){
    // console.log(56458)
    // alert("updated")

    return this.api.update(this.carlist.carId ,this.carlist)
    .subscribe( result =>
      {
        result=this.carlist
        alert("updated")
      }
      );
  }
  carId(carId: any, carlist: any) {
    throw new Error('Method not implemented.');
  }
}
