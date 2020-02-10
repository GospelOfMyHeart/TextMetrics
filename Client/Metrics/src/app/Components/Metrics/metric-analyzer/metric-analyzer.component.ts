import { MetricsService } from './../../../Services/metrics-service.service';
import { Component, OnInit } from '@angular/core';
import { MetricModel } from 'src/app/Models/MetricModel';


@Component({
  selector: 'app-metric-analyzer',
  templateUrl: './metric-analyzer.component.html',
  styleUrls: ['./metric-analyzer.component.css']
})
export class MetricAnalyzerComponent implements OnInit {
  
  metricModels: MetricModel[] = [];

  isError: boolean = false;
  errorText: string = "";

  constructor(
    private service: MetricsService
  ) { }

  ngOnInit() {
  }
  public onTextSubmit(model: string){
    this.service.calculateMetrics(model).subscribe(()=>{
      this.service.getMetrics().subscribe((data:MetricModel[])=>{
        this.isError=false;
        this.metricModels = data;
      })
    },
    (error)=>{
      this.isError=true;
      switch(error.status){
        case 500: {
          this.errorText = "Ошибка сервера"; break;
        }
        case 400:{
          this.errorText = "Введите текст";break;
        }
          case 0:{
            this.errorText= "Нет доступа к серверу"; break;
          }
          default:{
            this.errorText = "Неизвестная ошибка";break;
          }
      }
    });
  }

}
