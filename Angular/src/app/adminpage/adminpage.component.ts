import { Component, OnInit } from '@angular/core';
import { ApiService } from '../service/api.service';

@Component({
  selector: 'app-adminpage',
  templateUrl: './adminpage.component.html',
  styleUrls: ['./adminpage.component.css']
})
export class AdminpageComponent implements OnInit {
  constructor(private api:ApiService){}
  ngOnInit(): void {
    this.getCars()
  }
  carlist!:any
  private getCars():void
  {
    this.api.GetAllCarDetails().subscribe(res=>{
      this.carlist=res
      console.log(this.carlist)
    })
  }
}
