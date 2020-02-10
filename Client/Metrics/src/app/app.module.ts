import {  HttpClientModule } from '@angular/common/http';
import { MetricsService as MetricsService } from './Services/metrics-service.service';
import { AppRoutingModule } from './RouterModule/app-routing/app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule }   from '@angular/forms';
import { AppComponent } from './app.component';
import { MetricComponent } from './Components/Metrics/metric/metric.component';
import { MetricListComponent } from './Components/Metrics/metric-list/metric-list.component';
import { TextInputComponent } from './Components/Metrics/text-input/text-input.component';
import { MetricAnalyzerComponent } from './Components/Metrics/metric-analyzer/metric-analyzer.component';

@NgModule({
  declarations: [
    AppComponent,
    MetricComponent,
    MetricListComponent,
    TextInputComponent,
    MetricAnalyzerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [MetricsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
