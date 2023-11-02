# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

During this assessment, you may use most other resource besides your fellow students.  Feel free to google, look back at your notes, lessons, labs, etc... **you may not use Chat GPT or any other AI tool**

## Set Up

Fork this repository! (Don't clone it yet!!)

## Questions (12 Points Possible)
Edit this `README.md` file - answer the 6 questions before moving on to the exercise.  Make sure to save your changes to the README before moving on to the exercises!

To Edit the README:
* click the pencil icon in the upper right corner.
* make changes in the text editor.
* save your changes by clicking 'Commit Changes'
    * on the confirmation screen, click 'Commit Changes'
 
</br>
</br>

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    
    Option C is not a valid way to create an instance of Chair. This is because it does not include the class name Chair anywhere in the declaration - the word Chair is necessary in order to tell the program which class we are creating an instance of.
   
3. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:

OOP refers to Object Oriented Programming, which is one of the foremost paradigms in programming. In OOP, our code is distributed amongst different objects, which we can create specific instances of. Each new instance of an object inherits all of the properties and methods of its object prototype. OOP allows for modular and readable code - if one object declaration is incorrect, our other objects are relatively unaffected as they are each in their own file, and a fellow programmer knows exactly where to look in order to address the issue. In C#, objects take the form of classes, but all of the same principles still apply.

4. What is Automated Testing?

Automated testing refers to the process of creating a test project that refers back to the original project. This test project contains all of tests we wish to run on the original project. Automated testing differs from manual testing, where we test our project by simply running the code.

5. What are some benefits of creating tests for our projects?

Creating tests for our projects allows us to test our code as we write it. Rather than relying on executing the finished code to see if our program works, we can write tests for each class in our program as we create them. This allows us to identify/address bugs more clearly as they come up, rather than after we've built our entire program. This in turn ensures that we can find out where bugs are occuring once we've finished coding our program. Rather than relying on guesswork that may compromise the functionality of the entire program, we can run individual tests and figure out where errors are happening specifically.

6. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?

You need to add a project reference to the test file that refers to the project you wish to test.

7. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working. You do not need to write the whole test, just what you would **name** the test methods. Ex: `IsCreatedWithTwoArguments()`
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Summary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```

Constructor_WhenInstantiated_SetsPropertyValues

NumberOfWheelsProperty_CanBeRetrieved

ColorProperty_CanBeRetrieved

MilesDrivenProperty_CanBeRetrieved

Summary_ReturnsDesiredString

Drive_AddsToMilesDrivenProperty

Paint_ReassignsColorProperty


## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When the assessment is due, your instructors will show you how to commit the code you worked on in Visual Studio and push it up to GitHub :) 

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
