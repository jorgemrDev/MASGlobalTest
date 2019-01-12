import { Component } from '@angular/core';
import { ApiServices } from './services/api.services';
import { Employee } from './models/employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [ApiServices]
})
export class AppComponent {
  title = 'MAS Global Frontend';
  public employees: Array<Employee>;
  public idToFind: string;


getEmployees() {
  let parameter = this.idToFind;
  this.apiService.getEmployeesList(parameter).subscribe(
    data =>  {
                this.employees = JSON.parse(data.text());
              },
    error =>  console.log('error: ', error),
    );
}

constructor(public apiService: ApiServices) {
  this.idToFind = null;
  this.getEmployees();
 }
}

