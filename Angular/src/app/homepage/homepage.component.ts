import { Component, OnInit } from '@angular/core';
import { trigger, transition, style, animate } from '@angular/animations';
import { ApiService } from '../service/api.service';


@Component({
  selector: 'app-home-page',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css'],
  animations: [
    trigger('sedanAnimation', [
      transition(':enter', [
        style({ opacity: 0, transform: 'translateX(-20px) translateY(20px)' }),
        animate('3000ms', style({ opacity: 1, transform: 'translateX(0) translateY(0)' }))
      ])
    ]),
    [
      trigger('suvAnimation', [
        transition(':enter', [
          style({ opacity: 0, transform: 'translateX(20px) translateY(-20px)' }),
          animate('3000ms', style({ opacity: 1, transform: 'translateX(0) translateY(0)' }))
        ])
      ])
    ]
  ]
  
  
})

export class HomepageComponent implements OnInit {
  public sedan: any
  public suv: any
  constructor(private api:ApiService){}
  ngOnInit(): void {
    this.Bulletsedan();
    this.Bulletsuv();
  }
  private Bulletsedan(): void {
    this.api.GetBySedan().subscribe(result => {
      this.sedan = result;
      console.log('done');
    });
  }
  private Bulletsuv(): void {
    this.api.GetBySuv().subscribe(result => {
      this.suv = result;
      console.log("done");
    })
  }

  public rent()
  {
    
    alert('Car Rented Successfully');
  }
}