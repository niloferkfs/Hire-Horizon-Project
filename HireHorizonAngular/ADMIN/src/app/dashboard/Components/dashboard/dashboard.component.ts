import { Component } from '@angular/core';
import { DashboardService } from '../../Services/dashboard.service';
import {
  Chart,
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend
} from 'chart.js';
Chart.register(
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend
);

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {

  totalJobsPosted:any;
  jobseekers:any;
  totalCompanies:any;
  
  chart:any;
  constructor(private dashboardService: DashboardService) { }


  ngOnInit(): void {
    this.getTotaljobsPosted();
    this.getTotaljobSeekers();
    this.getTotalcompanies();
    this.getTotalJobProviders();
    
  }
  

  getTotaljobsPosted(){
    this.dashboardService.getTotaljobsPosted().subscribe((response:{count:number}) => {

       this.totalJobsPosted= response.count;
      
    },
      error => {
        console.error('Error fetching total count', error);
      }
    );
  
  }
  getTotaljobSeekers() {
    this.dashboardService.getTotaljobSeekers().subscribe((result:any[]) => {

      console.log(result);

      this.jobseekers= result.length;
     
     
    },
      error => {
        console.error('Error fetching total count', error);
      }
    );
   
  }
  getTotalcompanies() {
    this.dashboardService.getTotalcompanies().subscribe((response: { count: number }) => {

      console.log(response);
      this.totalCompanies = response.count;
      
    },
      error => {
        console.error('Error fetching total count', error);
      }
    );
  }
  getTotalJobProviders() {
    this.dashboardService.getTotalJobProvider().subscribe((response: { count: number }) => {
      this.totalCompanies = response.count;
      console.log("totalJobProviders:",this.totalCompanies);
      this.createChart();
    },
      error => {
        console.error('Error fetching total count', error);
      }
    );
  }
  createChart() {
    const ctx = document.getElementById('myChart') as HTMLCanvasElement;
    const myChart = new Chart(ctx, {
      type: 'bar',
      data: {
        labels: ['JobsPosted', 'JobSeekers','JobProviders'],
        datasets: [{
          label: 'Total Count',
          data: [
            this.totalJobsPosted,      
            this.jobseekers,             
            this.totalCompanies,
        
            
            
          ],
          backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
          ],
          borderColor: [
            'rgba(255, 99, 132, 1)',
            'rgba(54, 162, 235, 1)',
            'rgba(255, 206, 86, 1)',
          ],
          borderWidth: 1,
          barThickness: 50
        }]
       
      },
      options: {
        scales: {
          y: {
            beginAtZero: true
          }
        }
      }
    });
    console.log( "jobs"+this.totalCompanies  );
   
  }

  single = [
    {
      name: 'Category 1',
      value: 40
    },
    {
      name: 'Category 2',
      value: 60
    },
  ];

  view: [number, number] = [700, 400];
  showLegend = true;
  explodeSlices = false;

}


