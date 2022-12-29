import { UserService } from './../../shared/user.service';
import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormBuilder, FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { Registration } from 'src/app/shared/models/registration.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styles: []
})
export class RegistrationComponent implements OnInit {




  registrationForm = new FormGroup({
    Name: new FormControl('a', Validators.required),
    Email: new FormControl('a@a',  [Validators.required , Validators.email]),

    DateOfBirth: new FormControl('2002-06-09', Validators.required),
    ContactNumber: new FormControl('06512331', Validators.required),

  });



  constructor(public service: UserService,private router: Router, private fb:FormBuilder, private toastr: ToastrService) { }

  ngOnInit() {
  }

  onSubmit() {


    let regModel = new Registration();
    regModel.name = this.registrationForm.controls['Name'].value
     regModel.email = this.registrationForm.controls['Email'].value

    regModel.dateOfBirth = this.registrationForm.controls['DateOfBirth'].value
    regModel.contactNumber = this.registrationForm.controls['ContactNumber'].value


          this.service.register(regModel).subscribe(//
          data =>{
            this.router.navigate(['home']);
          },
          error=>{
            this.toastr.error("Error");

          }
        );



  }

}
