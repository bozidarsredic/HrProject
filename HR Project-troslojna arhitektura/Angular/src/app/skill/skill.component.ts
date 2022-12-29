import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Registration } from '../shared/models/registration.model';
import { Skill } from '../shared/models/skill.model';
import { SkillService } from '../shared/skill.service';
import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-skill',
  templateUrl: './skill.component.html',
  styleUrls: ['./skill.component.css']
})
export class SkillComponent implements OnInit {
  addskillForm = new FormGroup({
    SkillName: new FormControl('a', Validators.required),


  });
  constructor(public service: SkillService,private router: Router, private fb:FormBuilder, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit() {


    let regModel = new Skill();
    regModel.skillName = this.addskillForm.controls['SkillName'].value


    this.service.addskill(regModel).subscribe(//
    data =>{


      this.router.navigate(['home']);

    },
    error=>{
      this.toastr.error("Error");

    }
  );







  }

}
