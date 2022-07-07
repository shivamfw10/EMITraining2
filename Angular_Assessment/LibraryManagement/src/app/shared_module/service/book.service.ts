import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';

import { Books } from 'src/app/module/material/books.model';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

const apiUrl = environment.bookUrl;
@Injectable({
  providedIn: 'root'
})

export class BookService {
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
  public getBooks():Observable<Books[]>{
    return this.http.get<Books[]>(apiUrl).pipe(catchError(this.handleError));
  }
  
  public getBookById(id:number):Observable<Books>{
    const url = `${apiUrl}/${id}`;
    return this.http.get<Books>(url).pipe(catchError(this.handleError));
  }
  public addBook(Book:any):Observable<Books>{
    return this.http.post<Books>(apiUrl,Book);    
  }
  public updateBook(id:number,Book:any):Observable<Books>{
    const url =`${apiUrl}/${id}`;
    return this.http.patch<Books>(url,Book).pipe(catchError(this.handleError));
  }
  public deleteBook(id:number){
    const url = `${apiUrl}/${id}`;
    return this.http.delete<Books>(url).pipe(catchError(this.handleError));
  }
}
