import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environments';
import { Observable } from 'rxjs';
import { Skill } from '../Models/skill';

@Injectable({
  providedIn: 'root'
})
export class SkillServiceService {

  constructor(private http:HttpClient) { }

private getSkillsUrl=environment.baseurl+'/GetSkills';
private addSkillUrl = environment.baseurl+'/skillAdd';
private deleteSkillUrl=environment.baseurl+'/skillRemove';

 addSkill(skill: Skill): Observable<Skill> {
  return this.http.post<Skill>(this.addSkillUrl, skill);
}

  getSkills(): Observable<Skill[]> {
    return this.http.get<Skill[]>(this.getSkillsUrl);
  }
  deleteSkill(skillId: string): Observable<void> {
   
    return this.http.delete<void>(this.deleteSkillUrl+`${skillId}`);
  }
}
