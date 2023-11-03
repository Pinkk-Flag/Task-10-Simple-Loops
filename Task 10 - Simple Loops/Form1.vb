Public Class Form1
    '/////
    ' Hello! You can follow me on GitHub here:https://github.com/Pinkk-Flag
    ' MIT Lisence
    ' Created by Dario Gerald, 2023, November 11
    '/////


    Private Sub btnFirst20_Click(sender As Object, e As EventArgs) Handles btnFirst20.Click
        ' Put the first 20 integers into the listbox
        ' This is a simple algorithm
        ' Similar to how Python works
        ' It will reiterate through the list
        ' In python, you would do "For i in range(...)"
        ' Which is quite similar to this
        Dim i As Integer
        lstNum.Items.Clear()


        'This is in the range 1 -> 20
        For i = 1 To 20
            WasteTime(0.05) 'To help cache and prevent errors if the code goes wrong and reiterates too much
            lstNum.Items.Add(i)
        Next
    End Sub
    Private Sub btnMin2Max_Click(sender As Object, e As EventArgs) Handles btnMin2Max.Click
        ' Defines a variable "i" (short for "index")
        Dim i As Integer

        'Clears the items when it is clicked for good user experience
        lstNum.Items.Clear()

        ' Takes the value from min to max and prints them in that range
        For i = vsbMin.Value To vsbMax.Value
            WasteTime(0.125) 'To help cache and prevent errors if the code goes wrong and reiterates too much
            lstNum.Items.Add(i)
        Next
    End Sub

    Private Sub vsbMin_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbMin.Scroll
        'Put the value of the scroll bar into the label
        lblMin.Text = vsbMin.Value
    End Sub
    Private Sub vsbMax_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbMax.Scroll
        'Put the value of the scroll bar into the label
        lblMax.Text = vsbMax.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form is loaded, all values are cleared
        'This is to prevent certain errors
        lstNum.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Simply ends the process
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' The Reset section
        ' Resets all the values back to the ground state
        lblMax.Text = "Void"
        lblMin.Text = "Void"
        lstNum.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Simple help message to assist the user
        MsgBox("Hello, this is the simple loop program. To start, you can either chose between viewing the first 20 (by clicking the button) or by seeing the the minimum to maximum you want with the scroll bar values that you chose (also chosen by the button). The other buttons also do the process as intended. It is recommended you have a play around with the buttons to see what you like. Have fun!")
    End Sub

    '////////////////
    ' QUESTIONS / EXTENSION PART
    '////////////////

    Private Sub btnFirst10Multiples3_Click(sender As Object, e As EventArgs) Handles btnFirst10Multiples3.Click
        ' First of all, we declare the variables as usual
        ' However, we also need another 'answer' variable
        Dim i As Integer
        Dim answer As Integer

        'Clear the previous items
        lstNum.Items.Clear()


        ' For that range...
        For i = 1 To 10
            WasteTime(0.125) 'To help cache and prevent errors if the code goes wrong and reiterates too much
            answer = i * 3 ' The new 'answer' that'll be printed must be the values in the range multiplied by 3
            lstNum.Items.Add(answer) 'Log the answers
        Next
    End Sub

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

    ' End Section
    Sub WasteTime(ByVal timeToWaste As Single)
        ' slow down the process by the amount of "timeToWaste"
        Dim startTime As Single
        startTime = Microsoft.VisualBasic.DateAndTime.Timer

        Do While startTime + timeToWaste > Microsoft.VisualBasic.DateAndTime.Timer
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

End Class
