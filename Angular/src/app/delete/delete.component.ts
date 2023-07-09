import { Component } from '@angular/core';
import { ApiService } from '../service/api.service';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent {
  carId!:any
constructor(private api:ApiService){}
  delbtn():void
  {
    console.log('hi')
    this.api.delbyId(this.carId).subscribe(res=>{
      alert("deleted")
    })
  }
}
