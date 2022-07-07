import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';

import { Injectable } from '@angular/core';
import { Requestedbook } from 'src/app/module/requestedbook.model';
import { environment } from 'src/environments/environment';

const apiUrl = environment.requestUrl;
@Injectable({
  providedIn: 'root'
})
export class ReqbookService {
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
  public addRequestedBook(data:any):Observable<Requestedbook[]>{
    return this.http.post<Requestedbook[]>(apiUrl,data);    
  }
  public getBooks():Observable<Requestedbook[]>{
    return this.http.get<Requestedbook[]>(apiUrl).pipe(catchError(this.handleError));
  }
  
}
