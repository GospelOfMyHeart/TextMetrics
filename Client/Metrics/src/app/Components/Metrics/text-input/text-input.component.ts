import { Component, OnInit, Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-text-input',
  templateUrl: './text-input.component.html',
  styleUrls: ['./text-input.component.css']
})
export class TextInputComponent {

  @Output()
  textSubmit: EventEmitter<string> = new EventEmitter();

  inputText: string;

  constructor() { }
  submitText(){
    this.textSubmit.emit( this.inputText);
  }

}
