import { Component } from '@angular/core';
import { CalculatorService } from 'src/app/core/services/calculator.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.scss']
})
export class CalculatorComponent {

  constructor(
    private calculatorService: CalculatorService
  ) {}

}
