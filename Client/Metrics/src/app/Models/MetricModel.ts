export class MetricModel{
    metricName: string;
    metricTitle: string;
    value: string;
    constructor(values: Object = {}){
        Object.assign(this,values);
    }
}