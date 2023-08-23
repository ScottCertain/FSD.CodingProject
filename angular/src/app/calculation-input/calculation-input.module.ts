import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { CalculationInputRoutingModule } from './calculation-input-routing.module';
import { CalculationInputComponent } from './calculation-input.component';


@NgModule({
  declarations: [
    CalculationInputComponent
  ],
  imports: [
    CalculationInputRoutingModule,    
    SharedModule
  ]
})
export class CalculationInputModule { }
