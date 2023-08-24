import type { AuditedEntityDto, EntityDto } from '@abp/ng.core';
import type { CalculationType } from './calculation-type.enum';

export interface CalculationInputDto extends AuditedEntityDto<string> {
  calculationInputId: string;
  jobsPerMonth: number;
  payrollRevenuePercent: number;
  billRatePerJob: number;
  percentRecurringHomesLostPerMonth: number;
  percentNetProfit: number;
  percentRateIncrease: number;
  percentExpectedJobLoss: number;
  lowerPayrollRevenuePercent: number;
  improveRecurringHomesLostPerMonthPercent: number;
  calculationType: CalculationType;
}

export interface CreateUpdateCalculationInputDto {
  jobsPerMonth: number;
  payrollRevenuePercent: number;
  billRatePerJob: number;
  percentRecurringHomesLostPerMonth: number;
  percentNetProfit: number;
  percentRateIncrease: number;
  percentExpectedJobLoss: number;
  lowerPayrollRevenuePercent: number;
  improveRecurringHomesLostPerMonthPercent: number;
  calculationType: CalculationType;
}
