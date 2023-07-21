import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.scss']
})
export class CustomersComponent extends BaseComponent implements OnInit{
  constructor(spinner:NgxSpinnerService){
    super(spinner); //JavaScriptte baseclass'ın constructurına super keywordü ile erişebiliyoruz.
  }
  ngOnInit(): void {
    this.showSpinner(SpinnerType.BallAtom);
  }
}
