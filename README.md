## Lab 1 - Find Numbers in a String with Characters

Create a console application that asks the user to enter a text (string) in the console.
The entered string should then be searched for all substrings that are numbers that begin
and end with the same digit, without the start/end digit, or any other character besides
digits occurring in between.

For example, 3463 is a correct such number, but 34363 is not because there is
another 3 in the number, besides the start and end digits. Strings with letters in them
e.g., 95a9 are also not a correct number.

### Print and highlight each correct substring.

For each such substring that matches the criterion above, the program should print a
line with the <b>entire string</b>, but <b>where the substring is highlighted</b> in a different color.
Example output for input "29535123p48723487597645723645":

<span style="background-color: red;">2953512</span>3p48723487597645723645<br>
29<span style="background-color: red;">535</span>123p48723487597645723645<br>
295<span style="background-color: red;">35123</span>p48723487597645723645<br>
29535123p<span style="background-color: red;">48723</span>487597645723645<br>
29535123p4<span style="background-color: red;">872348</span>7597645723645<br>
29535123p48<span style="background-color: red;">723487</span>597645723645<br>
29535123p487<span style="background-color: red;">2348759764572</span>3645<br>
29535123p4872<span style="background-color: red;">3487597645723</span>645<br>
29535123p48723<span style="background-color: red;">48759764</span>5723645<br>
29535123p4872348<span style="background-color: red;">7597</span>645723645<br>
29535123p48723487<span style="background-color: red;">597645</span>723645<br>
29535123p4872348759<span style="background-color: red;">76457</span>23645<br>
29535123p48723487597<span style="background-color: red;">6457236</span>45<br>
29535123p487234875976<span style="background-color: red;">4572364</span>5<br>
29535123p4872348759764<span style="background-color: red;">5723645</span><br>

You can choose which colors you print with as long as you can see the difference between them. You
change color by changing the value of Console.ForegroundColor.

### Add up all the numbers and print the total.

The program should also add up all the numbers it has found as above and print it
last in the program. Feel free to make an empty line in between to distinguish from the output above.
Example output for input "29535123p48723487597645723645":
Total = 5836428677242