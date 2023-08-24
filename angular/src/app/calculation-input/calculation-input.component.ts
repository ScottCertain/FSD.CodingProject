import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { CalculationInputService, CalculationInputDto, calculationTypeOptions } from '@proxy/calculation-inputs';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-calculation-input',
  templateUrl: './calculation-input.component.html',
  styleUrls: ['./calculation-input.component.scss'],
  providers: [ListService],
})
export class CalculationInputComponent implements OnInit {
  calculationInput = { items: [], totalCount: 0 } as PagedResultDto<CalculationInputDto>;

  form: FormGroup;
  id = '2a6bee75-6ba6-3a7a-bd0d-3a0d36053cad'  // temporary hard-coded id
  selectedCalculationInput = {} as CalculationInputDto;
  calculationTypes = calculationTypeOptions;
  isModalOpen = false;

  constructor(
    public readonly list: ListService, 
    private calculationInputService: CalculationInputService,
    private fb: FormBuilder) { }

  ngOnInit() {
    const calculationInputStreamCreator = (query) => this.calculationInputService.getList(query);

    this.list.hookToQuery(calculationInputStreamCreator).subscribe((response) => {
      this.calculationInput = response;
    });
  }

  editCalculationInputs(id: string) {
    this.calculationInputService.get(id).subscribe((calculationInput) => {
      this.selectedCalculationInput = calculationInput;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  buildForm() {
    this.form = this.fb.group({
      JobsPerMonth: [this.selectedCalculationInput.jobsPerMonth || '', Validators.required],
      PayrollRevenuePercent: [this.selectedCalculationInput.payrollRevenuePercent || '', Validators.required],
      BillRatePerJob: [this.selectedCalculationInput.billRatePerJob || '', Validators.required],
      PercentRecurringHomesLostPerMonth: [this.selectedCalculationInput.percentRecurringHomesLostPerMonth || '', Validators.required],
      PercentNetProfit: [this.selectedCalculationInput.percentNetProfit || '', Validators.required],
      PercentRateIncrease: [this.selectedCalculationInput.percentRateIncrease || '', Validators.required],
      PercentExpectedJobLoss: [this.selectedCalculationInput.percentExpectedJobLoss || '', Validators.required],
      LowerPayrollRevenuePercent: [this.selectedCalculationInput.lowerPayrollRevenuePercent || '', Validators.required],
      ImproveRecurringHomesLostPerMonthPercent: [this.selectedCalculationInput.improveRecurringHomesLostPerMonthPercent || '', Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.calculationInputService.update(this.selectedCalculationInput.id, this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}
