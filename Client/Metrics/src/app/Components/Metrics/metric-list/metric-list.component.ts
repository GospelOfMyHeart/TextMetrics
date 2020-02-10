import { MetricModel } from '../../../Models/MetricModel';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-metric-list',
  templateUrl: './metric-list.component.html',
  styleUrls: ['./metric-list.component.css']
})
export class MetricListComponent {

  @Input()
  metricModels: MetricModel[] = [];

  constructor() { }

}
