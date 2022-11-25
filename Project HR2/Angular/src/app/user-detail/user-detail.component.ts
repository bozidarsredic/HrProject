import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CandidatSkill } from '../shared/models/candidatSkill.model';
import { Registration } from '../shared/models/registration.model';
import { Skill } from '../shared/models/skill.model';
import { SkillService } from '../shared/skill.service';
import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit {
  user: string=""
  userobj: Registration= new Registration();
  constructor(private route:ActivatedRoute, private service:UserService,private service2:SkillService,private router: Router, private toastr: ToastrService) { }
  skills : Skill[] = [];
  myskills : Skill[] = [];
  availableSkills: Skill[] = [];
  candidatSkill : CandidatSkill= new CandidatSkill();

  ngOnInit() {
    this.user=localStorage.getItem('candidat')



  this.service2.getmySkills(Number(this.user)).subscribe(//
  data =>{
    this.myskills = data;
  },
  error=>{
    this.toastr.error("Error");

  }
);


    this.service2.getSkills().subscribe(//
    data =>{
      this.skills = data;
    },
    error=>{
      this.toastr.error("Error");

    }
  );





    this.service.getUserById(Number(this.user)).subscribe(
      (data:Registration) =>{
       this.userobj=data;




        },
      error =>{
       this.toastr.error("something was wrong!");
      }

     )



     this.service2.getavailableSkills(Number(localStorage.getItem('candidat'))).subscribe(//
     data =>{
       this.availableSkills = data;
     },
     error=>{
       this.toastr.error("Error");

     }
    );

  }


  AddSkil(skill:Skill){

    this.candidatSkill.Candidatsid=Number(localStorage.getItem('candidat'));

    this.candidatSkill.Skillsid=skill.id;
    this.service2.addskilltocandidat(this.candidatSkill).subscribe(//
    data =>{




    },
    error=>{
      this.toastr.error("Error");

    }
  );
  }


  DeleteSkil(skill:Skill){

    this.candidatSkill.Candidatsid=Number(localStorage.getItem('candidat'));

    this.candidatSkill.Skillsid=skill.id;
    this.service2.deleteskilltocandidat(this.candidatSkill).subscribe(//
    data =>{




    },
    error=>{
      this.toastr.error("Error");

    }
  );
  }


  DeleteCandidat(){
    this.service.deleteCandidat(Number(localStorage.getItem('candidat'))).subscribe(//
    data =>{

      this.router.navigate(['home']);


    },
    error=>{
      this.toastr.error("Error");

    }
  );

  }

}
