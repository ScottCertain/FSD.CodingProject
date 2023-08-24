import { mapEnumToOptions } from '@abp/ng.core';

export enum CalculationType {
  Current = 0,
  NewHourly = 1,
  NewFeeSplit = 2,
}

export const calculationTypeOptions = mapEnumToOptions(CalculationType);
