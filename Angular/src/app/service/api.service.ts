import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http:HttpClient) { }

  public  GetAllCarDetails():Observable<any>{
    return this.http.get("https://localhost:7281/api/cars");
  }
  public  delbyId(id:number):Observable<any>{
    return this.http.delete("https://localhost:7281/api/cars/"+id);
  }
  public addCar(carlist:any):Observable<any>
  {
    return this.http.post("https://localhost:7281/api/cars", carlist);
  }
  public update(id:number,updatedCar:any):Observable<any>
  {
    let url=("https://localhost:7281/api/cars/" + id);
    return this.http.put(url, updatedCar);
  }
  public  GetBySedan():Observable<any>{
    return this.http.get("https://localhost:7281/api/cars/namesedan");
  }
  public  GetBySuv():Observable<any>{
    return this.http.get("https://localhost:7281/api/cars/namesuv");
  }
  
}
