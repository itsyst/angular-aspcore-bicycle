import { Make } from '@/app/types/make';
import { environment } from '@/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, tap } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class MakeService {

  constructor (private http: HttpClient) { }

  getAll() {
    return this.http.get<Make[]>(environment.apiMake)
      .pipe(
        map((response: Make[]) => response),
        tap(_ => console.log('fetched data')),
        catchError<any, any>(() => console.log("An unexpected error occurred!")));
  }
}


