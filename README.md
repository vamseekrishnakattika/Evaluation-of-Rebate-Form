# Evaluation-of-Rebate-Form

Evaluation is a crucial part of user interface design.  Use the rebate entry program you have written to do the following:
1.	Put the program in its own directory with nothing else so it does not interfere with your assignment.
2.	Use the program to enter 10 records into the program.  Record the time from start to finish to enter all 10 records, including pauses between records.  You can use a timer on your phone for this.  The program you will write will also measure this time.  Use the following standard data for each record:
A.	First name: Aaaaaaaaaa1 (increment the number for subsequent records)
B.	Last name: Bbbbbbbbbb
C.	Middle initial: F
D.	Address line 1: 1234 Main St.
E.	City, state, zip: Dallas, TX 75001
F.	Phone: 1112223333
G.	E-mail address: abc@utdallas.edu
H.	Proof of purchase: Yes
I.	Date: default.
3.	Write a program that analyzes the data file and writes the following things to a text file and to the screen:
a.	The number of records (should be 10.)
b.	The minimum, maximum, and average time to enter a single record.  Remember that records written by the program contain the start and stop time for that record.  Times should be in MM:SS format.
c.	The minimum, maximum, and average time between finishing entering a record and starting the next one.
d.	The total time from starting to enter the first record to finishing the last one.
e.	The number of times the user presses the “backspace” key while entering all 10 records.  To do this you will have to modify your original program to count the backspace key and put the count at the end of the existing record.  At the form level, there is a way to capture every keystroke, and you can look for character hex 08.
4.	This being a class in the design of user interfaces, your program must use a graphical interface to guide the user through the process of analysis.  Considering the kind of program, you should include instructions and descriptive text.  For example, the user should be able to specify a file name, etc.
5.	This program must be written in C# using WinForms or WPF, or in Java using Swing and/or JavaFX.
The text file output from this program should look something like this:
	Number of records: 10
	Minimum entry time: 1:12
	Maximum entry time: 2:06
	Average entry time: 1:37
Minimum inter-record time: 0:03
	Maximum inter-record time: 0:9
	Average inter-record time: 0:05
	Total time: 16:12
	Backspace count: 14
