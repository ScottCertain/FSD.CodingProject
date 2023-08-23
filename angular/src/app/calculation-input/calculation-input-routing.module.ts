import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculationInputComponent } from './calculation-input.component';

const routes: Routes = [
  { path: '', component: CalculationInputComponent },
  // { path: 'calculation-input', loadChildren: () => import('./calculation-input.module').then(m => m.CalculationInputModule) }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CalculationInputRoutingModule { }
