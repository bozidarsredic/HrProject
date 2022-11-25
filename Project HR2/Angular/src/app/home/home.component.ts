import { UserService } from './../shared/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ToastrService } from 'ngx-toastr';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Registration } from '../shared/models/registration.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styles: []
})
export class HomeComponent implements OnInit {

  users : Registration[] = [];
  constructor(public service: UserService,private router: Router, private toastr: ToastrService) { }

  ngOnInit() {

    this.service.getUsers().subscribe(//
    data =>{
      this.users = data;


    },
    error=>{
      this.toastr.error("Error");

    }
  );
}

Edit(candidat:Registration){
  localStorage.setItem('candidat', candidat.id.toString());
  this.router.navigate(['userDetail']);
}

}
