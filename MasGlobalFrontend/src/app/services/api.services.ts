import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { map } from 'rxjs/operators';

@Injectable()
export class ApiServices {
 constructor(private http: Http) {
 }

 extractData(res: Response) {
     return res.json();
 }

 getEmployeesList(idToFind) {
    const apiUrl = 'http://localhost:52821/';
     let urlCall = apiUrl + 'api/employees/';
     urlCall = idToFind != null ? urlCall + idToFind : urlCall;
     return this.http.get(urlCall);
 }
}
