import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CoreService } from '../../core.service';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.scss']
})
export class LogInComponent implements OnInit {

  selected = new FormGroup({
    email: new FormControl('', [Validators.email, this.checkAppropriateField]),
    password: new FormControl('', [Validators.required, this.checkAppropriateField])
  });
  constructor(private coreService: CoreService, private router: Router, private helper: JwtHelperService) { }

  ngOnInit(): void {

  }

  logIn(): void {
    this.coreService.logIn(this.selected.value).subscribe(result => {
      localStorage.setItem('token', result);
      window.location.reload();
    });
    this.router.navigateByUrl("/TERC/DajWojewodztwa");

  }

  checkAppropriateField(formControl: FormControl) {
    if (formControl.value == '' && formControl.value.indexOf('') != -1) {
      return { badInputValue: true }
    }
    return null;
  }

}
