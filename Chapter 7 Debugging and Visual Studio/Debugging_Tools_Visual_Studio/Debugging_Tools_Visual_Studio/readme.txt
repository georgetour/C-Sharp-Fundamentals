First run the application with ctlr + F5

- We have an application that must show the smallest numbers in console
- If we run the application we will see it will show 6, 5, 4 from our list which aren't the smallest so something is wrong

To see what's happening we must use breakpoints and run your app in Debug mode

- To add a breakpoint just click left where you want or F9 and the code to stop running like in 
	1.Add_Breapoint.jpg in Debugging Screenshots 

- Then you can see the values of the variables in breakpoint as shown in
	2.Values_Of_Variables_at_Breakpoint.jpg in Debugging Screenshots

	or by hovering as shown in 
	3.Hover_and_Inspect

You see that the values are 6, 5, 4

Add another brakpoint with F9 to var min = GetSmallest(list);

Ass you can see we have a value 6 for min in line smallests.Add(min);

IMPORTANT
Go to Debug -> Windows ->Watch ->Watch 1 
in this windows we can watch our variables and look at them at all time

We have put the variables we want to watch as shown in 4.Watch_Variables_Values_Live.jpg but list[i] shows an error 
since i haven't been defined yet. You will see min is red colored since it just changed
As you notice list[i] becomes 2 and in our logic we are saying if min < list[i] then min = list[i] so min will become the bigger
number and not the smallest
	5.Found_the_Problem.jpg

So we must change the logic and make smaller sign to bigger from


To Step Over execution F10
To Step Into F11

Keyboard shortcuts
Ctrl + F5 Run without debug
F5 run in debug mode
Shift+F5 stop debugging
F5 contunue to next breakpoint
F9 add breakpoint in line 
F10 Step Over
F11 Step Into
Shift + F11 Step Out

Delete all breakpoints
- Screenshot 6.Delete_All_Brakpoints or 7.Delete_All_Brakpoints_2

Call Stack Window
If we want to see how we get to our breakpointwhere we can check the call stack which shows the order of what was run as shown in 8.Call_Stack_Window from bottom to current


Autos and Locals
Instead of using the Watch window and putting manually variables u can use autos or locals windows which visual studio automatically detects variables you might want to
see as shown in 9.Autos_and_Locals.jpg.