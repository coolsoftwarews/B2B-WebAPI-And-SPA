export const environment = {
    production: false,
    b2bConfig:{
      clientId: "<app-id>",
      authority: 'https://login.microsoftonline.com/<tenant-id>',//when multi-tenant then use common instead of tenant id
      redirectUrl: 'http://localhost:4200',
      resources: {
      scopes: ['<exposed api>'],
      uri: 'https://localhost:44303'
      }
    }
  }
  