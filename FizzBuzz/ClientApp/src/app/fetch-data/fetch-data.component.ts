import { Component, Inject, Input, OnInit, OnChanges } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators'
import { Observable } from 'rxjs';
import { Subject } from "rxjs";


@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent  {
  public resultNumbers: FizzBuzzModel[];
  @Input() numbers;
  baseUrl: string;
  
  constructor(private http: HttpClient,  @Inject('BASE_URL') baseUrl: string) {
    //console.log(this.numbers);
    this.baseUrl = baseUrl;
  }

  getData(inputText: string): void {

    if (inputText != null && inputText != '') {
      let headers = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json; charset=UTF-8'
        })
      };

      var payload = { Data: inputText };
      var url = this.baseUrl + 'home';
      console.log(payload);
      this.http.post<FizzBuzzModel[]>(url, payload, headers).subscribe(result => {
        this.resultNumbers = result;
      }, error => console.error(error));

    }
    else {
      this.resultNumbers = null;
    }
  }

}

interface FizzBuzzModel {
  number: string;
  result: any;
}
