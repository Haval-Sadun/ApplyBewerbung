# ApplyBewerbung

## The steps are :
### 1.  Create ASP.NET Core Project
### 2.  Setup Domain Project
     2.1 Create the Aggregates, Entites, View Objects
### 3.  Setup Application Project
    | create Contracts for Persistense Layer 
      | IGeneric <T> ository - > that will be inhereted from IApplyRepository<A>will be implemented in Persistense layer
  3.0 Create the Dtos
  3.1  Setup AutoMapper
      package name : AutoMapper.Extensions.Microsoft.DependencyInjection
      | Create Profile
  3.2  Add DependencyInjection > Class to be used in the Api (we any Package we added to app to DependencyInj)
  3.3  Adding MediatR and CQRS
      | in this steps we Add the Featue - Entities - Request/Handlers
  3.3  Using Fluent Validation
  3.4  Using Custom Response Types
  3.5   addingEntity Framework Core
### 4.  Setup Persistence Project.
  4.1 Adding Repository Pattern  > implementing the repositories from App layer
  
2:29:52 Implementing the Infrastructure Layer
2:45:52 Adding API Project (.NET 6)
2:54:36 Setting Up API Controllers
3:13:33 Seeding Database Data
3:18:21 Testing with Swagger UI
3:24:55  Adding MVC UI Project
3:27:09 Using NSwag and NSwag Studio
3:50:04 Setting up Leave Type Module
4:30:11 Implementing API Authentication
5:07:07 Adding Authentication to UI
5:37:42 Setup Leave Allocation Module
5:56:33 Setup Leave Request Module
6:41:56 Adding Unit Of Work Pattern
6:55:33 Adding Global Exception Handling to API
7:04:12 Conclusion
