# Task-10-Simple-Loops
---
Hello! This was personally one of my favourite projects to do in VB.NET honestly!
Gave me so much expertise and experience in understanding one of most crucial concepts in computer science in general
Also was able to learn how to use a technique that's similar to f-strings in python, in VB.

This block of code really encapsulates what I really mean:
```
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Declare variables, as usualy
        Dim i As Integer
        Dim multiple5 As Integer
        ' Clear previous set as usual
        lstNum.Items.Clear()
        ' Same range
        For i = 1 To 20
            WasteTime(0.3) 'To help cache and prevent errors if the code goes wrong and reiterates too much
            multiple5 = i * 5 'The multiple of 5 will be computed under this variable


            ' This is a relatively niche and unused feature of VB.NET
            ' This is similar to how the f string works in python

            ' It is very similar to the previous except we are logging both with a gap in between
            lstNum.Items.Add($"{i} ---> {multiple5}")
        Next
    End Sub
```

# Also, please remember to use the MASTER branch, not the main branch
## Sorry for the inconvenience ;)
