import { MetricModel } from '../../../Models/MetricModel';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-metric',
  templateUrl: './metric.component.html',
  styleUrls: ['./metric.component.css']
})
export class MetricComponent {

  @Input()
  metricModel: MetricModel = new MetricModel({metricName:"test",metricTitle:"desc",value:"1"});

  constructor() { }


}
