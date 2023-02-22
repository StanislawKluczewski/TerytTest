import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CoreService } from '../../core.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit {

  selected = new FormGroup({
    login: new FormControl('', [Validators.email, this.checkAppropriateField]),
    email: new FormControl('', [Validators.email, this.checkAppropriateField]),
    password: new FormControl('', [Validators.required, this.checkAppropriateField])
  });
  constructor(private coreService: CoreService, private router: Router) { }

  ngOnInit(): void {
  }

  SignUp(): void {
    this.coreService.signUp(this.selected.value).subscribe(result => {
      console.log(result);
      this.router.navigateByUrl('/Start/Log-in')
    });
  }

  checkAppropriateField(formControl: FormControl) {
    if (formControl.value == '' && formControl.value.indexOf('') != -1) {
      return { badInputValue: true }
    }
    return null;
  }
}
