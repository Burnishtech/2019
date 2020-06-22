import { Component } from '@angular/core';
import { NgForm, Form } from '@angular/forms';
import { Authservice, AuthResponseBody } from './auth.service';
import { delay } from 'rxjs/internal/operators/delay';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html'
})
export class AuthComponent {
  constructor(private authService :Authservice){

  }
  isLoginMode=true;
  islaoding =false;
  onerror :string =null;
 
onswitchLoginmode(){

  this.isLoginMode=!this.isLoginMode;
}
onSubmit(form:NgForm){
  let authobservable:Observable<AuthResponseBody>;
  let email=form.value.email;
  let password=form.value.password;
  this.islaoding=true;
  if ( this.isLoginMode)
  {
    authobservable= this.authService.login(email,password)
  }
  
  else 
  {
    
  if(!form.valid)
  {
    return ;
  }
 
  delay (4000)
  authobservable =  this.authService.SignUP(email,password)
  }
  // returnSecureToken:true
  authobservable.subscribe(responsedata=>
    {      
      console.log(responsedata)
      this.islaoding=false;
    },
    error =>{
      console.log(error);
      this.onerror="Some thing went wrong!! ask Tapas";
      this.islaoding=false;
    }
    );

console.log(form.value);
form.reset();



}
}
