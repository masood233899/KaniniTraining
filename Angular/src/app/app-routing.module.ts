import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { LoginpageComponent } from './loginpage/loginpage.component';
import { SignuppageComponent } from './signuppage/signuppage.component';
import { AdminpageComponent } from './adminpage/adminpage.component';
import { AddComponent } from './add/add.component';
import { UpdateComponent } from './update/update.component';
import { DeleteComponent } from './delete/delete.component';

const routes: Routes = [
  {path:'home', component:HomepageComponent},
  { path: '', component: LoginpageComponent },
  {path: 'signup', component: SignuppageComponent},
  {path:'admin', component:AdminpageComponent},
  { path: 'admin/add', component: AddComponent },
  {path: 'admin/update', component: UpdateComponent},
  {path: 'admin/delete', component: DeleteComponent},



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
