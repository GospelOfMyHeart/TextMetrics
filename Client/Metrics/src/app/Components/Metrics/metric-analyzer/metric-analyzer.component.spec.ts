import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MetricAnalyzerComponent } from './metric-analyzer.component';

describe('MetricAnalyzerComponent', () => {
  let component: MetricAnalyzerComponent;
  let fixture: ComponentFixture<MetricAnalyzerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MetricAnalyzerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MetricAnalyzerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
