import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field'
import { ReactiveFormsModule } from "@angular/forms";
import { MatInputModule } from '@angular/material/input';
import { RouterModule } from '@angular/router';

import { SignUpComponent } from './components/sign-up/sign-up.component';
import { LogInComponent } from './components/log-in/log-in.component';

@NgModule({
  declarations: [
    SignUpComponent,
    LogInComponent
  ],
  exports: [],
  imports: [
    FormsModule,
    MatButtonModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatInputModule,
    HttpClientModule,
    BrowserModule,
    RouterModule,
  ]
})
export class CoreModule { }
