import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';

import { Injectable } from '@angular/core';
import { Users } from 'src/app/module/material/users.model';
import { environment } from 'src/environments/environment';

const apiUrl=environment.userUrl;
@Injectable({
  providedIn: 'root'
})
export class UserService {

  private handleError(errorResponse:HttpErrorResponse){
    if(errorResponse.error instanceof ErrorEvent){
      console.log('Client Side Error', errorResponse.error);
    }
    else{
      console.log('Server Side Error',errorResponse.error)
    }
    return throwError('Their is a problem in your code');
  }
  constructor(private http:HttpClient) {}
  public getUsers():Observable<Users[]>{
    return this.http.get<Users[]>(apiUrl).pipe(catchError(this.handleError));
  }
  
  public getUserById(id:number):Observable<Users>{
    const url = `${apiUrl}/${id}`;
    return this.http.get<Users>(url).pipe(catchError(this.handleError));
  }
  public addUser(user:any):Observable<Users>{
    return this.http.post<Users>(apiUrl,user);    
  }
  public updateUser(id:number,user:any):Observable<Users>{
    const url =`${apiUrl}/${id}`;
    return this.http.patch<Users>(url,user).pipe(catchError(this.handleError));
  }
  public updateUserBook(id:number,user:any):Observable<Users>{
    const url =`${apiUrl}/${id}`;
    return this.http.patch<Users>(url,user).pipe(catchError(this.handleError));
  }
  public deleteUser(id:number){
    const url = `${apiUrl}/${id}`;
    return this.http.delete<Users>(url).pipe(catchError(this.handleError));
  }
}
