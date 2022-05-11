import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration-page',
  templateUrl: './registration-page.component.html',
  styleUrls: ['./registration-page.component.scss']
})
export class RegistrationPageComponent {

  constructor() { }

registerForm = new FormGroup({
  firstname: new FormControl('', Validators.required),
  lastname: new FormControl('', Validators.required),
  email: new FormControl('', [
    Validators.required,
    Validators.pattern(/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/g)
  ]),
  password: new FormControl('', Validators.required),
  confirmpassword: new FormControl('', Validators.required)
});

get firstName() {
  return this.registerForm.get('first-name');
}

get lastName() {
  return this.registerForm.get('last-name');
}

get email() {
  return this.registerForm.get('email');
}

onSubmit() {

}
}
