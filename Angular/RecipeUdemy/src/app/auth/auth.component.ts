import { Component } from '@angular/core';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html'
})
export class AuthComponent {
isLoginMode=true;
onswitchLoginmode(){

  this.isLoginMode=!this.isLoginMode;
}

}
