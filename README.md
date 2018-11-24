# UnitTestsTutorial
*Code samples for Unit Testing for Unity tutorial.*

Read the full tutorial:

https://www.jonathanyu.xyz/2018/11/24/unit-testing-in-unity/



I consider automated tests to be a cornerstone of building high quality software. Testing should be taken seriously in all aspects of software development and creating games in Unity should be no exception. In this post I'll focus on the unit testing aspect of test driven development (TDD).

I've found that Unity resources and tutorials rarely stress the importance of tests. This post is meant to act as an introduction to unit testing and provide some samples on how to write unit tests for Unity in C#.
Unit tests in a nutshell

On the surface unit testing is just a method of testing software. Unit refers to the smallest testable part of an application. In Unity C# (or in most OOP languages), the smallest testable part is an individual method. Each method has some functionality and the test is written to assert the expected behavior.

Unit tests are written independent from other parts of the code base. Dependencies on other classes should be substituted or mocked. This forms the basis of why unit tests push developers to create decoupled code. Tightly coupled interfaces make for a large number of dependencies and make testing difficult.


Dependencies:

```
NUnit
Unity 2018.2
```
