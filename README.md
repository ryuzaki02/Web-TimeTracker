# Web-TimeTracker

A web application about the task-time tracking.

Hi Brent,

As you know web is new to me and since i am a developer i like to learn and do coding with proper architecure pattern. So without having prior experience in Web.
I am still learning implementation of MVVM pattern in this project.

Checkin 2
So I was stuck with two major issues (major for me atleast).
1. Passing the data with the help of view model to and from view to controller. 

Description - 
I was trying to pass the user object from user Index.cshtml to time sheet Index.cshtml. But i found out that controller class instantiate everytime you access any of its method.

Workaround/Trial/Research -
I tried few different things. First I tried capture user object in the controller hoping it would retain but i was wrong.
Then i tried passing user id to get Create method hoping it would reating even for the same post Create method but i was wrong.
Then i tried retaining it with view model but still the same issue persist.

Resolution - 
After having discussion with you. You guided me we can achieve the same with the help of new model but do not add it to database.


2. Adding Date and Time type to the cshtml

Description - 
I was trying to add calendar picker and time picker from cshtml

Workaround/Trial/Research -
I tried some stackoverflow suggestions like adding type to the textform
Some were saying to add it to the header html and scripts but could not work

Resolution - 
After having discussion with you. You guided me we can achieve the same with the help of database model and the data type.


Check-in 3 Updates


