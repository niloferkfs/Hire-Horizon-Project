import { Component,OnInit } from '@angular/core';
import { JobSeekerService } from '../../Services/job-seeker.service';
import { data } from '../../Models/JobSeekerListModel';

@Component({
  selector: 'app-job-seeker',
  templateUrl: './job-seeker.component.html',
  styleUrls: ['./job-seeker.component.css']
})
export class JobSeekerComponent implements OnInit {

  data: data[]=[];

  constructor(private dataService: JobSeekerService) { }

  ngOnInit(): void {
    this.dataService.getData().subscribe((result) => {
      this.data = result;
      console.log(this.data);
    });
  }

}
