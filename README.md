# ApplyBewerbung

## The steps are :
 1.  Create ASP.NET Core Project
 2. Setup Domain Project
    - Create the Aggregates, Entites, View Objects
 3. Setup Application Project
    - create Contracts   
      - IGeneric<T> Repository for Persistense Layer
     > that will be inhereted from IApplyRepository<Apply>, that will be implemented in **Persistense layer**
      - IEmailSender 
     > for the **Infrastructure Layer** to impolement
    - Create the Dtos
    - Setup `AutoMapper`
     > package name : `AutoMapper.Extensions.Microsoft.DependencyInjection` 
    - Create Profile
    - Add DependencyInjection 
     > Class to be used in the Api (we any Package we added to app to DependencyInj)
    - Adding MediatR and CQRS
     > in this steps we Add the Featue - Entities - Request/Handlers
    -  Using Fluent Validation
    -  Using Custom Response Types
    -  Adding Entity Framework Core
  4. Setup Persistence Project.
     - Adding Repository Pattern  > implementing the repositories from App layer
  
- Implementing the Infrastructure Layer
-Adding API Project (.NET 6)
-Setting Up API Controllers
-Seeding Database Data
