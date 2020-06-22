import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { catchError } from 'rxjs/operators';

export interface AuthResponseBody{
    idToken:string;
    email:string;
    refreshToken:string;
    expiresIn:string;
    localId:string;
    registered:boolean;

}
@Injectable({ providedIn: 'root' })
export class Authservice{
    constructor (private HttpClient:HttpClient){
      
      
    }

    login(email: string, password: string) {
        return this.HttpClient
          .post<AuthResponseBody>(
            'https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=AIzaSyD61t5HAt6ifdzK6ieWtuQL-Pf5v2u-jX0',
            {
              email: email,
              password: password,
              returnSecureToken: true
            }
          );
      }


    
SignUP(email:string,password:string)
{
   
   return this.HttpClient.post<AuthResponseBody>('https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=AIzaSyD61t5HAt6ifdzK6ieWtuQL-Pf5v2u-jX0',    
    {
        email:email,
        password:password,
        returnSecureToken:true

      
    });

}
}