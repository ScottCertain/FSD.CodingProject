import type { CalculationInputDto, CreateUpdateCalculationInputDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CalculationInputService {
  apiName = 'Default';
  

  create = (input: CreateUpdateCalculationInputDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CalculationInputDto>({
      method: 'POST',
      url: '/api/app/calculation-input',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/calculation-input/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CalculationInputDto>({
      method: 'GET',
      url: `/api/app/calculation-input/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<CalculationInputDto>>({
      method: 'GET',
      url: '/api/app/calculation-input',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdateCalculationInputDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CalculationInputDto>({
      method: 'PUT',
      url: `/api/app/calculation-input/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
