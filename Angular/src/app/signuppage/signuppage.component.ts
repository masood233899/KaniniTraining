import { Component } from '@angular/core';
import { SignupService } from '../service/signup.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Status } from '../models/status';
import { validPattern } from '../helpers/patter-match.validator';
import { MustMatch } from '../helpers/must-match.validator';

@Component({
  selector: 'app-signuppage',
  templateUrl: './signuppage.component.html',
  styleUrls: ['./signuppage.component.css']
})
export class SignuppageComponent {
  constructor(private signupService:SignupService,private fb:FormBuilder) { }
  
  frm!:FormGroup;
  status!:Status;

  get f(){
    return this.frm.controls;
  }

  onPost(){
     this.status = {statusCode:0,message:"wait.."};
     this.signupService.signup(this.frm.value).subscribe({
      next: (res)=>{
        console.log(res);
        this.status=res;
        this.frm.reset();
      },
      error: (err)=>{
       this.status.statusCode=0;
       this.status.message= "some error on server side";
      console.log(err);
      },
      complete:()=>{
       
      }
     })
  }

  ngOnInit(): void {
    const patternRegex= new RegExp('^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$');
    // must be atleast 6 character long,must contain 1 uppercase, 1 lowercase, 1 digit and 1 special character
    this.frm= this.fb.group({
       'name':['',Validators.required],
       'email':['',Validators.required],
       'username':['',Validators.required],
       'password':['',[Validators.required,validPattern(patternRegex)]],
       'confirmPassword':['',Validators.required]
    },{
      validator:MustMatch('password','confirmPassword')
    })
  }

}
