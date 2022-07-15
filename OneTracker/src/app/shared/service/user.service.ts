import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';

import { Injectable } from '@angular/core';
import { User } from '../models/user.model';
import { environment } from 'src/environments/environment';

const apiUrl = environment.userUrl;
@Injectable({
  providedIn: 'root'
})
export class UserService {
  private handleError(errorResponse:HttpErrorResponse)
  {
    if(errorResponse.error instanceof ErrorEvent){
      console.log('Client Side Error',errorResponse.error);
    }
    else{
      console.log('Server Side Error',errorResponse.error)
    }
    return throwError('Their is a problem in ur code');
  }
  constructor(private http:HttpClient) { }
  public getUsers():Observable<User[]>{
    return this.http.get<User[]>(apiUrl).pipe(catchError(this.handleError));
  }

  public getUserById(id:number):Observable<User>{
    const url=`${apiUrl}/${id}`;
    return this.http.get<User>(url).pipe(catchError(this.handleError));
  }

  public addUser(emp:any):Observable<User>{
    return this.http.post<User>(apiUrl,emp);
  }
  public deleteUser(id:any):Observable<User>{
    const url=`${apiUrl}/${id}`;
    return this.http.delete<User>(url).pipe(catchError(this.handleError));
  }
  public EditUser(id:number,emp:any):Observable<User>{
    const url=`${apiUrl}/${id}`;
    return this.http.patch<User>(url,emp).pipe(catchError(this.handleError));
  }
}
