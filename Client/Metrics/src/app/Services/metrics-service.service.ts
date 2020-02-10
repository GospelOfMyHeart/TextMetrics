import { MetricsDataViewModel } from './../ViewModels/MetricsDataViewModel';
import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { MetricModel } from '../Models/MetricModel';

@Injectable()
export class MetricsService {

  API_URL = environment.metricsApiRoute;

  constructor(
    private http: HttpClient
  ) { }

  public getMetrics(): Observable<MetricModel[]>{
     return this.http.get<MetricModel[]>(this.API_URL);
  }
  public calculateMetrics(text: string): Observable<null>{
    return this.http.post<null>(this.API_URL, new MetricsDataViewModel({dataString:text}));
  }
}
