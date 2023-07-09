import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ApiService } from '../service/api.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {
  constructor(private build:FormBuilder, private api: ApiService){}
  ngOnInit(): void {  
    this.addgrp=this.build.group({ 
    carName:[],
    carType:[],
    price:[],
    availability:[]
  });

  }
  public addgrp!:FormGroup

private init():void{

}

public addbtn():void
{
  this.api.addCar(this.addgrp.value).subscribe(res=>{
    alert('added!');
    
  })
}
}
