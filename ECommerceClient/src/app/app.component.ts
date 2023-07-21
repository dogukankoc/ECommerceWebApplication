import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ECommerceClient';
  constructor(private toastrService: CustomToastrService){
    toastrService.message('Hello', 'Doğukan', {
      messageType: ToastrMessageType.Info,
      position: ToastrPosition.TopCenter,
    });
    toastrService.message('Hello', 'Doğukan', {
      messageType: ToastrMessageType.Error,
      position: ToastrPosition.BottomLeft,
    });
    toastrService.message('Hello', 'Doğukan', {
      messageType: ToastrMessageType.Warning,
      position: ToastrPosition.BottomRight,
    });
    toastrService.message('Hello', 'Doğukan', {
      messageType: ToastrMessageType.Success,
      position: ToastrPosition.TopLeft,
    });
    toastrService.message('Hello', 'Doğukan', {
      messageType: ToastrMessageType.Warning,
      position: ToastrPosition.TopRight,
    });
  }}
