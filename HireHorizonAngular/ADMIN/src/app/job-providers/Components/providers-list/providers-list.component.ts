import { Component,OnInit } from '@angular/core';
import { Companies } from '../../Models/Companies';
import { CompanyService } from '../../Services/company.service';

@Component({
  selector: 'app-providers-list',
  templateUrl: './providers-list.component.html',
  styleUrls: ['./providers-list.component.css']
})
export class ProvidersListComponent implements OnInit{

  companies: Companies[] = [];
  searchTerm: string = '';

  constructor(private companyService: CompanyService){}

  ngOnInit(): void {
    
    this.companyService.getCompanies().subscribe((result)=>{
      this.companies=result;
      console.log(this.companies);
  });
}
filterCompany() {
  this.companyService.searchCompany(this.searchTerm).subscribe((result)=>{
    this.companies=result;
  })
}
removeCompany(companyId:string){
  console.log(companyId);
this.companyService.removeCompany(companyId).subscribe((response)=>{
  console.log("Company Deleted",response);
  window.location.reload();
},
  error => {
    console.error('Error removing company', error);
  }
);
}


}
