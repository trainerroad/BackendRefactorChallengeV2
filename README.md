## Welcome
Thanks for taking the time to download this refactoring exercise. If we love your refactoring and 
your resume is legit, we'll move to the next step. This might seem like a lot of hoops to 
jump through, but it's way better than hiring someone who answers trivia questions in an 
interview well but can't code worth a damn.

Use the instructions below to complete the exercise. Some items are intentionally vague and are designed to 
test a basic understanding of working with Visual Studio and the .Net ecosystem. 

Pretend this code is part of a more extensive software system which you are being asked to take 
**ownership** of while providing regular updates and enhancements going forward. 

#### Required Software

You will need Visual Studio 2019 to complete this exercise. 
You can download it from https://visualstudio.microsoft.com/downloads/

## Provided Code

#### IUnitOfWork
- Assume the UnitOfWork is wrapping an Entity Framework context and that when using `Query<T>` you are ultimately 
  reading data from a Sql Azure database.
- The implementation for IUnitOfWork is not complete, and does not need to be in order to complete the exercise. 
- You should use the Async extension methods in the `System.Data.Entity` namespace which is part of the 
  EntityFramework NuGet package. Use version 6.4.4 of the NuGet package. 
  - Example Usage: `UnitOfWork.Query<Foo>().Where(x => x.Bar == 1).ToListAsync();`
- When writing unit tests you should use `TestDbAsyncEnumerable<T>` to help mock out calls to `Query<T>`.
  `TestDbAsyncEnumerable<T>` is provided for you the `BikeDistributor.TestUtils` project 
  which can be found in the src folder.

#### Domain
- The domain classes represent tables in a Sql Azure database. 
- Certain values have been hard coded to provide a simple example. It is up to you to decide which values should remain
  hard coded, and which should not.
- You may add additional domain classes to satisfy the requirements below
- You do not need to worry about adding properties for Foreign Keys. For example, Order just contains 
  a collection of OrderLines and OrderLine does not contain a foreign key property for Order.Id.  

#### Unit Test Project
- BikeDistributor.Test which exists in the src folder, contains an example unit test for the order class. 
- All of your tests should be added to this test project in an organized fashion. The default namespace
  is correctly set to just `BikeDistributor`. 
- You are required to use XUnit as the unit test framework
- You may use either XUnit or FluentAssertions to write your assertions

## Requirements

- Use the latest stable versions for all NuGet packages
- You may use additional NuGet packages which are available on NuGet.org
- We will be using the unit tests that you write to verify the functionality of your solution.
  - Visual Studio's test runner will be used to execute the unit tests. 
  - Do not create an executable project
  - Do not use an actual database
- Make the code async where possible
  - Async method names should end in Async
- Extend the provided code to support: 
  - More bikes at new prices
  - Different discount codes and percentages
  - Additional receipt formats (you do not need to create a new receipt format, but can if you want to)
- Assume the BikeDistributor project will be used by a top level project, such as an API project. Provide the following:
  - A way to get all orders by Company Name
  - A way to generate a specific type of receipt for a given Order Id

You will be graded on:
- Did you follow all instructions and satisfy all of the requirements
- Did you adequately prove that your code works
- Can another developer easily understand and extend your work

#### Extra Credit
- Show that the BikeDistributor class library can be used from both .Net 4.72 and .Net Core 3.1. 
- Convert the BikeDistributor class library into a proper multi-targeted project supporting both .Net 4.72 and .Net Core 3.1

## Submitting

Zip up your project (remove .vs, obj, bin, TestResults folders) and submit it with your resume. 
Don't do a PR/Fork as everyone else would see your work and could copy it.



