# TPC Interview Test
Please fork this repo and submit the link to your forked repo.

We are testing basic c# and javascript skills. 

## Javascript
Fire up a terminal and change to `./src/JsStuff` and run `npm install`

We are using mochajs for testing. Use `npm run test` to execute the test runner.

See the comments in `hello.js` and `hello-test.js` on what to write.

## C#
We are using dotnet core. Fire up the Visual Studio and load `TpcInterviewTest.sln`

This is a short refactoring exercise.

The class `Services.Logger` violates the Open Close Principle.

Refactor this class so that message logging types are passed in when constructing `Services.Logger` and write a test in the `Services.UnitTests` project ensure `Services.Logger.Log` is being called with a single string parameter.

You don't need to install or use an IOC package - We are just looking to see how you refactor and write tests

Xunit and MOQ (alpha) have already been installed in the solution. If you have a different preferred mocking or fakes framework, feel free to change it :)


