import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

import { Registration } from './models/registration.model';
import { Skill } from './models/skill.model';
import { CandidatSkill } from './models/candidatSkill.model';

@Injectable({
  providedIn: 'root'
})
export class SkillService {

  constructor( private http: HttpClient) { }


  addskill(skill:Skill) :Observable<String> {

    return this.http.post<String>(environment.serverURL + '/api/skill/add', skill);

  }
  getSkills() : Observable<Skill[]> {
    return this.http.get<Skill[]>(environment.serverURL + '/api/skill/all');
  }
  addskilltocandidat(candidatSkill:CandidatSkill) :Observable<String> {

    return this.http.post<String>(environment.serverURL + '/api/skill/addskilltocandidat', candidatSkill);

  }

  getmySkills(id:number) : Observable<Skill[]> {
    return this.http.get<Skill[]>(environment.serverURL + `/api/skill/${id}`);
  }

 getavailableSkills(id:number) :Observable<Skill[]> {

    return this.http.post<Skill[]>(environment.serverURL + '/api/skill/getavailableskills', id);

  }

  deleteskilltocandidat(candidatSkill:CandidatSkill) :Observable<String> {

    return this.http.post<String>(environment.serverURL + '/api/skill/deleteskilltocandidat', candidatSkill);

  }



}
