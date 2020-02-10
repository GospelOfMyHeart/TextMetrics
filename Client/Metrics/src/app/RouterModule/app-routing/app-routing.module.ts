
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MetricAnalyzerComponent } from 'src/app/Components/Metrics/metric-analyzer/metric-analyzer.component';

const metricsRoute = "metrics"

const routes: Routes = [
  {
    path: metricsRoute,
    component: MetricAnalyzerComponent
  },
  {
    path: '**',
    redirectTo: metricsRoute,
    pathMatch: 'full'
  }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
