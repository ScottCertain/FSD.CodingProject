import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'CodingProject',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44362/',
    redirectUri: baseUrl,
    clientId: 'CodingProject_App',
    responseType: 'code',
    scope: 'offline_access CodingProject',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44362',
      rootNamespace: 'FSD.CodingProject',
    },
  },
} as Environment;
