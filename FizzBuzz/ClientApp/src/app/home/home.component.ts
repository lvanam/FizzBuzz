
import { Component, OnInit, ViewChild  } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FetchDataComponent } from "../fetch-data/fetch-data.component";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  @ViewChild(FetchDataComponent, { static: false }) childC: FetchDataComponent;
  showData: boolean = true;
  inputText: string = '';
  loading = false;
  constructor(private router: Router) { }

  ngOnInit() {
    //Nothing
  }

  fetchData() {
    
    this.childC.getData(this.inputText);
    
  };


  clearData() {
    this.inputText = '';
    this.fetchData();
  }
}
